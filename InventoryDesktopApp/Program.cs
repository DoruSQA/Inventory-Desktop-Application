using InventoryDesktopApp.Utils;
using System.Net.NetworkInformation;

namespace InventoryDesktopApp
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();
            await DataSeed.InitializeAsync();
            Application.Run(new LoginInterface());
        }

    }
}