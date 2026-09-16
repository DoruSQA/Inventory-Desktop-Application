using Guna.UI2.WinForms;
using System.Media;
using System.Runtime.InteropServices;

namespace InventoryDesktopApp
{
    public partial class MainInterface : Form
    {
        // =========================================================
        // WINDOWS API
        // =========================================================

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        // =========================================================
        // COLORS
        // =========================================================

        private static readonly Color BackgroundColor =
            Color.FromArgb(23, 26, 43);

        private static readonly Color SidebarColor =
            Color.FromArgb(20, 23, 40);

        private static readonly Color PanelColor =
            Color.FromArgb(32, 36, 58);

        private static readonly Color InputColor =
            Color.FromArgb(37, 42, 64);

        private static readonly Color PurpleColor =
            Color.FromArgb(124, 92, 252);

        private static readonly Color PurpleHoverColor =
            Color.FromArgb(146, 120, 255);

        private static readonly Color PurplePressedColor =
            Color.FromArgb(108, 76, 230);

        private static readonly Color WhiteColor =
            Color.FromArgb(255, 255, 255);

        private static readonly Color SecondaryTextColor =
            Color.FromArgb(167, 174, 196);

        private static readonly Color SuccessColor =
            Color.FromArgb(53, 201, 139);

        private static readonly Color ErrorColor =
            Color.FromArgb(255, 92, 112);

        private static readonly Color BorderColor =
            Color.FromArgb(58, 65, 96);

        private static readonly Color GridHeaderColor =
            Color.FromArgb(37, 42, 64);

        private static readonly Color GridRowColor =
            Color.FromArgb(32, 36, 58);

        private static readonly Color GridAlternateRowColor =
            Color.FromArgb(35, 40, 63);


        // =========================================================
        // VARIABLES
        // =========================================================

        public static int itemscount;
        public static decimal money;
        public static int customerscount;


        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public MainInterface()
        {
            InitializeComponent();

            Region = Region.FromHrgn(
                CreateRoundRectRgn(
                    0,
                    0,
                    Width,
                    Height,
                    20,
                    20));

            ApplyModernTheme();
        }


        // =========================================================
        // MODERN UI THEME
        // =========================================================

        private void ApplyModernTheme()
        {
            // -----------------------------------------------------
            // FORM
            // -----------------------------------------------------

            BackColor = BackgroundColor;
            ForeColor = WhiteColor;


            // -----------------------------------------------------
            // TAB CONTROL / SIDEBAR
            // -----------------------------------------------------

            guna2TabControl1.TabMenuBackColor = SidebarColor;

            guna2TabControl1.TabButtonIdleState.FillColor =
                SidebarColor;

            guna2TabControl1.TabButtonIdleState.ForeColor =
                SecondaryTextColor;

            guna2TabControl1.TabButtonIdleState.BorderColor =
                SidebarColor;

            guna2TabControl1.TabButtonIdleState.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Regular);

            guna2TabControl1.TabButtonHoverState.FillColor =
                Color.FromArgb(30, 34, 55);

            guna2TabControl1.TabButtonHoverState.ForeColor =
                WhiteColor;

            guna2TabControl1.TabButtonSelectedState.FillColor =
                PanelColor;

            guna2TabControl1.TabButtonSelectedState.ForeColor =
                WhiteColor;

            guna2TabControl1.TabButtonSelectedState.BorderColor =
                PurpleColor;

            guna2TabControl1.TabButtonSelectedState.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);


            // -----------------------------------------------------
            // TAB PAGES
            // -----------------------------------------------------

            InventoryTab.BackColor = BackgroundColor;
            CustomersTab.BackColor = BackgroundColor;
            SellTab.BackColor = BackgroundColor;
            LogsTab.BackColor = BackgroundColor;
            SettingsTab.BackColor = BackgroundColor;


            // -----------------------------------------------------
            // TOP BAR
            // -----------------------------------------------------

            loggedinuserLBL.ForeColor = WhiteColor;
            loggedinuserLBL.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            itemsCountLBL.ForeColor =
                SecondaryTextColor;

            itemsCountLBL.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Regular);

            totalmoneyLBL.ForeColor =
                SuccessColor;

            totalmoneyLBL.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            customerscountLBL.ForeColor =
                SecondaryTextColor;

            customerscountLBL.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Regular);


            // -----------------------------------------------------
            // MINIMIZE / EXIT
            // -----------------------------------------------------

            minimizeBTN.FillColor =
                Color.Transparent;

            minimizeBTN.HoverState.FillColor =
                Color.FromArgb(55, 60, 85);

            exitBTN.FillColor =
                Color.Transparent;

            exitBTN.HoverState.FillColor =
                ErrorColor;


            // -----------------------------------------------------
            // INVENTORY TITLE
            // -----------------------------------------------------

            label1.ForeColor = WhiteColor;

            label1.Font =
                new Font(
                    "Segoe UI",
                    22F,
                    FontStyle.Regular);


            // -----------------------------------------------------
            // SECTION LABELS
            // -----------------------------------------------------

            UIAddLBL.ForeColor = WhiteColor;
            UIAddLBL.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            UISortLBL.ForeColor = WhiteColor;
            UISortLBL.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            label2.ForeColor = WhiteColor;
            label2.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            label3.ForeColor = WhiteColor;
            label3.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);


            // -----------------------------------------------------
            // SORT COMBOBOX
            // -----------------------------------------------------

            SortByBox.FillColor = InputColor;

            SortByBox.BorderColor = BorderColor;

            SortByBox.BorderThickness = 1;

            SortByBox.ForeColor =
                SecondaryTextColor;

            SortByBox.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Regular);

            SortByBox.FocusedColor =
                PurpleColor;

            SortByBox.FocusedState.BorderColor =
                PurpleColor;

            SortByBox.HoverState.BorderColor =
                PurpleHoverColor;


            // -----------------------------------------------------
            // DESCENDING TOGGLE
            // -----------------------------------------------------

            DescToggleSwitch.CheckedState.FillColor =
                PurpleColor;

            DescToggleSwitch.CheckedState.BorderColor =
                PurpleColor;

            DescToggleSwitch.CheckedState.InnerColor =
                WhiteColor;

            DescToggleSwitch.UncheckedState.FillColor =
                Color.FromArgb(75, 82, 110);

            DescToggleSwitch.UncheckedState.BorderColor =
                Color.FromArgb(75, 82, 110);

            DescToggleSwitch.UncheckedState.InnerColor =
                WhiteColor;

            label2.ForeColor =
                SecondaryTextColor;


            // -----------------------------------------------------
            // INVENTORY TEXTBOXES
            // -----------------------------------------------------

            StyleTextBox(EditID);
            StyleTextBox(EditName);
            StyleTextBox(EditPrice);
            StyleTextBox(EditinStock);

            StyleTextBox(itemnametextbox);
            StyleTextBox(itempricetextbox);
            StyleTextBox(itemamounttext);


            // -----------------------------------------------------
            // INVENTORY BUTTONS
            // -----------------------------------------------------

            StylePrimaryButton(EditBTN);
            StylePrimaryButton(ConfirmEdit);
            StylePrimaryButton(AddItemBTN);

            StyleDangerButton(RemoveItemBTN);


            // -----------------------------------------------------
            // INVENTORY TABLE
            // -----------------------------------------------------

            StyleDataGrid(InventoryTable);


            // -----------------------------------------------------
            // CUSTOMER TITLE
            // -----------------------------------------------------

            customersLBL.ForeColor = WhiteColor;

            customersLBL.Font =
                new Font(
                    "Segoe UI",
                    22F,
                    FontStyle.Regular);


            // -----------------------------------------------------
            // CUSTOMER CONTROLS
            // -----------------------------------------------------

            StyleTextBox(CustomerID);
            StyleTextBox(CustomerName);
            StyleTextBox(CustomerPhone);
            StyleTextBox(CustomerEmail);

            StyleTextBox(CustomerAddName);
            StyleTextBox(CustomerAddPhone);
            StyleTextBox(CustomerAddEmail);


            // -----------------------------------------------------
            // CUSTOMER BUTTONS
            // -----------------------------------------------------

            StylePrimaryButton(guna2Button2);
            StyleDangerButton(guna2Button4);
            StylePrimaryButton(guna2Button1);
            StylePrimaryButton(CustomerAddBTN);


            // -----------------------------------------------------
            // CUSTOMER SORT
            // -----------------------------------------------------

            guna2ComboBox1.FillColor =
                InputColor;

            guna2ComboBox1.BorderColor =
                BorderColor;

            guna2ComboBox1.ForeColor =
                SecondaryTextColor;

            guna2ComboBox1.FocusedColor =
                PurpleColor;

            guna2ComboBox1.FocusedState.BorderColor =
                PurpleColor;

            guna2ComboBox1.HoverState.BorderColor =
                PurpleHoverColor;


            // -----------------------------------------------------
            // CUSTOMER TOGGLE
            // -----------------------------------------------------

            guna2ToggleSwitch1.CheckedState.FillColor =
                PurpleColor;

            guna2ToggleSwitch1.CheckedState.BorderColor =
                PurpleColor;

            guna2ToggleSwitch1.CheckedState.InnerColor =
                WhiteColor;

            guna2ToggleSwitch1.UncheckedState.FillColor =
                Color.FromArgb(75, 82, 110);

            guna2ToggleSwitch1.UncheckedState.BorderColor =
                Color.FromArgb(75, 82, 110);

            guna2ToggleSwitch1.UncheckedState.InnerColor =
                WhiteColor;

            label6.ForeColor =
                SecondaryTextColor;


            // -----------------------------------------------------
            // CUSTOMER TABLE
            // -----------------------------------------------------

            StyleDataGrid(CustomersTable);


            // -----------------------------------------------------
            // SEPARATORS
            // -----------------------------------------------------

            guna2vSeparator1.FillColor =
                BorderColor;

            guna2vSeparator2.FillColor =
                BorderColor;

            guna2vSeparator3.FillColor =
                BorderColor;

            guna2vSeparator4.FillColor =
                BorderColor;
        }


        // =========================================================
        // TEXTBOX STYLE
        // =========================================================

        private void StyleTextBox(Guna2TextBox textBox)
        {
            textBox.FillColor =
                InputColor;

            textBox.BorderColor =
                BorderColor;

            textBox.BorderThickness = 1;

            textBox.ForeColor =
                WhiteColor;

            textBox.PlaceholderForeColor =
                SecondaryTextColor;

            textBox.FocusedState.FillColor =
                InputColor;

            textBox.FocusedState.BorderColor =
                PurpleColor;

            textBox.HoverState.BorderColor =
                PurpleHoverColor;

            textBox.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Regular);

            textBox.BorderRadius = 8;
        }


        // =========================================================
        // PRIMARY BUTTON
        // =========================================================

        private void StylePrimaryButton(Guna2Button button)
        {
            button.FillColor =
                PurpleColor;

            button.ForeColor =
                WhiteColor;

            button.BorderColor =
                PurpleColor;

            button.BorderThickness = 0;

            button.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            button.BorderRadius = 8;

            button.HoverState.FillColor =
                PurpleHoverColor;

            button.HoverState.ForeColor =
                WhiteColor;

            button.PressedColor =
                PurplePressedColor;

            button.DisabledState.FillColor =
                Color.FromArgb(70, 75, 100);

            button.DisabledState.ForeColor =
                SecondaryTextColor;
        }


        // =========================================================
        // DANGER BUTTON
        // =========================================================

        private void StyleDangerButton(Guna2Button button)
        {
            button.FillColor =
                ErrorColor;

            button.ForeColor =
                WhiteColor;

            button.BorderColor =
                ErrorColor;

            button.BorderThickness = 0;

            button.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            button.BorderRadius = 8;

            button.HoverState.FillColor =
                Color.FromArgb(255, 110, 128);

            button.HoverState.ForeColor =
                WhiteColor;

            button.PressedColor =
                Color.FromArgb(220, 70, 90);
        }


        // =========================================================
        // DATAGRID STYLE
        // =========================================================

        private void StyleDataGrid(DataGridView grid)
        {
            grid.BackgroundColor =
                GridRowColor;

            grid.BorderStyle =
                BorderStyle.None;

            grid.GridColor =
                BorderColor;

            grid.EnableHeadersVisualStyles =
                false;

            // -----------------------------------------------------
            // HEADER
            // -----------------------------------------------------

            grid.ColumnHeadersDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = GridHeaderColor,
                    ForeColor = WhiteColor,
                    Font = new Font(
                        "Segoe UI",
                        9F,
                        FontStyle.Bold),
                    Alignment =
                        DataGridViewContentAlignment.MiddleLeft,
                    SelectionBackColor =
                        GridHeaderColor,
                    SelectionForeColor =
                        WhiteColor
                };

            grid.ColumnHeadersHeight = 34;

            // -----------------------------------------------------
            // ROWS
            // -----------------------------------------------------

            grid.DefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = GridRowColor,
                    ForeColor = SecondaryTextColor,
                    Font = new Font(
                        "Segoe UI",
                        9F,
                        FontStyle.Regular),
                    SelectionBackColor = PurpleColor,
                    SelectionForeColor = WhiteColor,
                    Alignment =
                        DataGridViewContentAlignment.MiddleLeft
                };

            // -----------------------------------------------------
            // ALTERNATING ROWS
            // -----------------------------------------------------

            grid.AlternatingRowsDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = GridAlternateRowColor,
                    ForeColor = SecondaryTextColor,
                    SelectionBackColor = PurpleColor,
                    SelectionForeColor = WhiteColor
                };

            // -----------------------------------------------------
            // ROW HEADERS
            // -----------------------------------------------------

            grid.RowHeadersDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = GridHeaderColor,
                    ForeColor = SecondaryTextColor,
                    SelectionBackColor = PurpleColor,
                    SelectionForeColor = WhiteColor
                };

            grid.RowHeadersWidth = 35;

            grid.RowTemplate.Height = 28;

            grid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            grid.MultiSelect = false;
        }


        // =========================================================
        // LOAD
        // =========================================================

        private async void Interface_Load(
            object sender,
            EventArgs e)
        {
            loggedinuserLBL.Text =
                (await Database.GetCredentials())[0];

            RefreshAll();
        }


        // =========================================================
        // DRAG FORM
        // =========================================================

        private void label1_Click_1(
            object sender,
            EventArgs e)
        {
        }

        private void label1_Click(
        object sender,
        EventArgs e)
        {
        }

        private void ProductsTab_MouseDown(
            object sender,
            MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();

                SendMessage(
                    Handle,
                    WM_NCLBUTTONDOWN,
                    HT_CAPTION,
                    0);
            }
        }

        private void Interface_MouseDown(
            object sender,
            MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();

                SendMessage(
                    Handle,
                    WM_NCLBUTTONDOWN,
                    HT_CAPTION,
                    0);
            }
        }

        private void MainInterfaceTabControl_MouseDown(
            object sender,
            MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();

                SendMessage(
                    Handle,
                    WM_NCLBUTTONDOWN,
                    HT_CAPTION,
                    0);
            }
        }

        private void Sold_MouseDown(
            object sender,
            MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();

                SendMessage(
                    Handle,
                    WM_NCLBUTTONDOWN,
                    HT_CAPTION,
                    0);
            }
        }


        // =========================================================
        // WINDOW BUTTONS
        // =========================================================

        private void exitBTN_Click(
            object sender,
            EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBTN_Click(
            object sender,
            EventArgs e)
        {
            WindowState =
                FormWindowState.Minimized;
        }

        private void resizeinterfaceBTN_Click(
            object sender,
            EventArgs e)
        {
            Size =
                MaximumSize == Size
                    ? MinimumSize
                    : MaximumSize;
        }


        // =========================================================
        // TAB CONTROL
        // =========================================================

        private void guna2TabControl1_Selected(
            object sender,
            TabControlEventArgs e)
        {
            PopulateTables();
        }


        // =========================================================
        // POPULATE TABLES
        // =========================================================

        private async void PopulateTables()
        {
            try
            {
                var items =
                    await Database.GetInventory();

                var customers =
                    await Database.GetCustomers();

                InventoryTable.DataSource =
                    items;

                itemscount =
                    items.Count;

                customerscount =
                    customers.Count;

                money =
                    items.Sum(
                        x => x.price * x.inStock);

                CustomersTable.DataSource =
                    customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // =========================================================
        // UPDATE TOP LABELS
        // =========================================================

        private void UpdateLabels()
        {
            itemsCountLBL.Text =
                $"{itemscount} items";

            totalmoneyLBL.Text =
                $"${money}";

            customerscountLBL.Text =
                $"{customerscount} customers";
        }


        // =========================================================
        // CUSTOMER TABLE
        // =========================================================

        private void customersTable_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void exitBTN_MouseHover(
            object sender,
            EventArgs e)
        {
        }


        // =========================================================
        // ADD ITEM
        // =========================================================

        private async void AddItemBTN_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (
                    Decimal.TryParse(
                        itempricetextbox.Text,
                        out decimal price)
                    &&
                    int.TryParse(
                        itemamounttext.Text,
                        out int amount)
                    &&
                    price > 0
                    &&
                    amount > 0)
                {
                    Item item =
                        new Item(
                            itemnametextbox.Text,
                            price);

                    await Database.AddItem(
                        item,
                        amount);

                    RefreshAll();

                    itempricetextbox.Text = "";
                    itemamounttext.Text = "";
                    itemnametextbox.Text = "";
                }
                else
                {
                    SystemSounds.Beep.Play();

                    MessageBox.Show(
                        "Invalid parameters",
                        "Error adding item",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // =========================================================
        // UNUSED PAINT EVENT
        // =========================================================

        private void splitContainer1_Panel2_Paint(
            object sender,
            PaintEventArgs e)
        {
        }


        // =========================================================
        // REFRESH ALL
        // =========================================================

        private async Task RefreshAll()
        {
            PopulateTables();

            UpdateLabels();

            InventoryTable.Refresh();

            CustomersTable.Refresh();

            SortByBox.Refresh();

            UpdateSortBox();
        }


        // =========================================================
        // INVENTORY TABLE
        // =========================================================

        private async void InventoryTable_CellEndEdit(
            object sender,
            DataGridViewCellEventArgs e)
        {
            var rowcells =
                InventoryTable.CurrentRow.Cells;

            try
            {
                if (rowcells != null)
                {
                    var myitem =
                        new Item(
                            (int)rowcells[0].Value,
                            (string)rowcells[1].Value,
                            (decimal)rowcells[2].Value,
                            (int)rowcells[3].Value,
                            (int)rowcells[4].Value,
                            (int)rowcells[5].Value);

                    await Database.UpdateItem(
                        myitem);

                    RefreshAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InventoryTable_CellBeginEdit(
            object sender,
            DataGridViewCellCancelEventArgs e)
        {
        }

        private void InventoryTable_CellValidating(
            object sender,
            DataGridViewCellValidatingEventArgs e)
        {
        }

        private void InventoryTable_RowValidating(
            object sender,
            DataGridViewCellCancelEventArgs e)
        {
        }

        private void InventoryTable_DataError(
            object sender,
            DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(
                "the value you entered is not of correct format",
                "invalid cell",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }


        // =========================================================
        // ADD LABEL
        // =========================================================

        private void UIAddLBL_Click(
            object sender,
            EventArgs e)
        {
        }


        // =========================================================
        // CUSTOMER SORT
        // =========================================================

        private async void guna2ComboBox1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                var customers =
                    await Database.GetCustomers();

                CustomersTable.DataSource =
                    guna2ToggleSwitch1.Checked
                        ? customers
                            .OrderByDescending(
                                x => x.GetProperty(
                                    guna2ComboBox1.SelectedIndex))
                            .ToList()
                        : customers
                            .OrderBy(
                                x => x.GetProperty(
                                    guna2ComboBox1.SelectedIndex))
                            .ToList();

                CustomersTable.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortByBox_DataSourceChanged(
            object sender,
            EventArgs e)
        {
        }


        // =========================================================
        // SORT INVENTORY
        // =========================================================

        private async Task UpdateSortBox()
        {
            if (SortByBox.Items.Count == 0)
            {
                int nColumns =
                    InventoryTable.Columns.Count;

                for (int i = 0; i < nColumns; i++)
                {
                    SortByBox.Items.Add(
                        InventoryTable.Columns[i].Name);
                }

                SortByBox.Refresh();
            }
        }


        private void InventoryTable_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }


        private async void DescToggleSwitch_CheckedChanged(
            object sender,
            EventArgs e)
        {
            RefreshAll();
        }


        // =========================================================
        // REMOVE ITEM
        // =========================================================

        private async void RemoveItemBTN_Click(
            object sender,
            EventArgs e)
        {
            await Database.RemoveItem(
                Convert.ToInt32(
                    InventoryTable.CurrentRow.Cells[0].Value));

            RefreshAll();
        }


        // =========================================================
        // ENTER = ADD ITEM
        // =========================================================

        private void itemamounttext_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddItemBTN.PerformClick();
            }
        }


        private void InventoryTable_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            // hi
        }


        private void InventoryTab_Click(
            object sender,
            EventArgs e)
        {
        }


        // =========================================================
        // EDIT ITEM
        // =========================================================

        private void EditBTN_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                Guna2TextBox[] textBoxes =
                {
                    EditID,
                    EditName,
                    EditPrice,
                    EditinStock
                };

                for (int i = 0; i < textBoxes.Length; i++)
                {
                    textBoxes[i].Text =
                        InventoryTable
                            .CurrentRow
                            .Cells[i]
                            .Value
                            .ToString();
                }
            }
            catch
            {
                // no row selected
            }
        }


        // =========================================================
        // CONFIRM EDIT ITEM
        // =========================================================

        private async void ConfirmEdit_Click(
            object sender,
            EventArgs e)
        {
            Guna2TextBox[] textBoxes =
            {
                EditID,
                EditName,
                EditPrice,
                EditinStock
            };

            bool IDValid =
                int.TryParse(
                    EditID.Text,
                    out int id);

            bool NameValid =
                EditName.Text.Length > 0;

            bool PriceValid =
                decimal.TryParse(
                    EditPrice.Text,
                    out decimal price);

            bool inStockValid =
                int.TryParse(
                    EditinStock.Text,
                    out int inStock);

            bool[] checks =
            {
                IDValid,
                NameValid,
                PriceValid,
                inStockValid
            };

            if (checks.All(x => x == true))
            {
                var item =
                    new Item(
                        id,
                        EditName.Text,
                        price,
                        inStock,
                        0,
                        0);

                try
                {
                    await Database.UpdateItem(item);

                    textBoxes
                        .ToList()
                        .ForEach(
                            x => x.Text = "");

                    RefreshAll();

                    MessageBox.Show(
                        "Successfully Updated Records!",
                        "Records Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(
                    "Invalid parameters");

                textBoxes
                    .ToList()
                    .ForEach(
                        x => x.Text = "");
            }
        }


        // =========================================================
        // EDIT CUSTOMER
        // =========================================================

        private void guna2Button2_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                Guna2TextBox[] textBoxes =
                {
                    CustomerID,
                    CustomerName,
                    CustomerPhone,
                    CustomerEmail
                };

                for (int i = 0; i < textBoxes.Length; i++)
                {
                    textBoxes[i].Text =
                        CustomersTable
                            .CurrentRow
                            .Cells[i]
                            .Value
                            .ToString();
                }
            }
            catch
            {
                // no row selected
            }
        }


        // =========================================================
        // REMOVE CUSTOMER
        // =========================================================

        private async void guna2Button4_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                await Database.RemoveCustomer(
                    Convert.ToInt32(
                        CustomersTable
                            .CurrentRow
                            .Cells[0]
                            .Value));

                RefreshAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // =========================================================
        // ADD CUSTOMER
        // =========================================================

        private async void CustomerAddBTN_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                Guna2TextBox[] textBoxes =
                {
                    CustomerAddName,
                    CustomerAddPhone,
                    CustomerAddEmail
                };

                bool isNameValid =
                    CustomerAddName.Text.Length > 0;

                bool isPhoneValid =
                    CustomerAddPhone.Text.Length > 0;

                bool isEmailValid =
                    CustomerAddEmail.Text.Length > 0;

                bool[] checks =
                {
                    isNameValid,
                    isPhoneValid,
                    isEmailValid
                };

                if (checks.All(x => x == true))
                {
                    await Database.AddCustomer(
                        new Customer(
                            CustomerAddName.Text,
                            CustomerAddPhone.Text,
                            CustomerAddEmail.Text));

                    textBoxes
                        .ToList()
                        .ForEach(
                            x => x.Text = "");

                    RefreshAll();
                }
                else
                {
                    SystemSounds.Beep.Play();

                    MessageBox.Show(
                        "Invalid parameters",
                        "Error adding Customer",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // =========================================================
        // CONFIRM EDIT CUSTOMER
        // =========================================================

        private async void guna2Button1_Click(
            object sender,
            EventArgs e)
        {
            Guna2TextBox[] textBoxes =
            {
                CustomerName,
                CustomerPhone,
                CustomerEmail
            };

            if (textBoxes.All(
                x => x.Text.Length > 0))
            {
                var customer =
                    new Customer(
                        Convert.ToInt32(
                            CustomerID.Text),
                        CustomerName.Text,
                        CustomerPhone.Text,
                        CustomerEmail.Text);

                try
                {
                    await Database.UpdateCustomer(
                        customer);

                    textBoxes
                        .ToList()
                        .ForEach(
                            x => x.Text = "");

                    RefreshAll();

                    CustomersTable.Refresh();

                    MessageBox.Show(
                        "Successfully Updated Records!",
                        "Records Update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(
                    "Invalid parameters..");

                textBoxes
                    .ToList()
                    .ForEach(
                        x => x.Text = "");
            }
        }


        // =========================================================
        // CUSTOMER EMAIL
        // =========================================================

        private void CustomerAddEmail_TextChanged(
            object sender,
            EventArgs e)
        {
        }
    }
}