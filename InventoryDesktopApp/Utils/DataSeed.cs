using System.Reflection;
using System.Text.Json;

namespace InventoryDesktopApp.Utils
{
    public static class DataSeed
    {
        private static SeedData seedData = new();
        public static async Task InitializeAsync()
        {
            string resourceName =
                "InventoryDesktopApp.Data.SeedData.json";

            Assembly assembly =
                Assembly.GetExecutingAssembly();

            using Stream? stream =
                assembly.GetManifestResourceStream(resourceName);

            if (stream == null)
            {
                throw new Exception(
                    $"Embedded resource '{resourceName}' was not found.");
            }

            using StreamReader reader =
                new StreamReader(stream);

            string json =
                await reader.ReadToEndAsync();

            seedData =
                JsonSerializer.Deserialize<SeedData>(
                    json,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    })
                ?? throw new Exception(
                    "Failed to load seed data.");

            await AddAdmin(seedData);
            await AddItems(seedData);
            await AddCustomers(seedData);
        }

        private static async Task AddAdmin(SeedData seedData)
        {
            bool adminExists = await Database.HasRegisteredAdmin();

            if (!adminExists)
            {
                await Database.AddAdmin(
                    seedData.Admin.Username,
                    seedData.Admin.Password);
            }
        }

        private static async Task AddItems(SeedData seedData)
        {
            var items = await Database.GetInventory();

            if (items.Count == 0)
            {
                foreach (var itemData in seedData.Items)
                {
                    Item item = new Item(
                        itemData.Name,
                        itemData.Price);

                    await Database.AddItem(
                        item,
                        itemData.Amount);
                }
            }
        }

        private static async Task AddCustomers(SeedData seedData)
        {
            var customers = await Database.GetCustomers();

            if (customers.Count == 0)
            {
                foreach (var customerData in seedData.Customers)
                {
                    Customer customer = new Customer(
                        customerData.Name,
                        customerData.PhoneNumber,
                        customerData.Email);

                    await Database.AddCustomer(customer);
                }
            }
        }

        private class SeedData
        {
            public AdminData Admin { get; set; } = new();

            public List<ItemData> Items { get; set; } = new();

            public List<CustomerData> Customers { get; set; } = new();
        }

        private class AdminData
        {
            public string Username { get; set; } = string.Empty;

            public string Password { get; set; } = string.Empty;
        }

        private class ItemData
        {
            public string Name { get; set; } = string.Empty;

            public decimal Price { get; set; }

            public int Amount { get; set; }
        }

        private class CustomerData
        {
            public string Name { get; set; } = string.Empty;

            public string PhoneNumber { get; set; } = string.Empty;

            public string Email { get; set; } = string.Empty;
        }

        public static string GetAdminUsername()
        {
            return seedData.Admin.Username;
        }

        public static string GetAdminPassword()
        {
            return seedData.Admin.Password;
        }
    }
}