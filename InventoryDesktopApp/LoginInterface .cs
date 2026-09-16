using InventoryDesktopApp.Utils;
using System.Runtime.InteropServices;

namespace InventoryDesktopApp
{
    public partial class LoginInterface : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

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

        public static bool registered;

        public LoginInterface()
        {
            InitializeComponent();

            // Rounded main window
            Region = Region.FromHrgn(
                CreateRoundRectRgn(
                    0,
                    0,
                    Width,
                    Height,
                    25,
                    25));

            // Rounded login panel
            loginPanel.Region = Region.FromHrgn(
                CreateRoundRectRgn(
                    0,
                    0,
                    loginPanel.Width,
                    loginPanel.Height,
                    20,
                    20));

            // Rounded login button
            loginBTN.Region = Region.FromHrgn(
                CreateRoundRectRgn(
                    0,
                    0,
                    loginBTN.Width,
                    loginBTN.Height,
                    12,
                    12));
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            registered = await Database.HasRegisteredAdmin();

            if (!registered)
            {
                loginBTN.Text = "Register";
            }

            if (registered)
            {
                rememberCHKBOX.Visible = true;

                if ((await Database.GetCredentials())[2] == "True")
                {
                    rememberCHKBOX.Checked = true;
                    usernameTXT.Text =
                        (await Database.GetCredentials())[0];
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private async void loginBTN_Click(object sender, EventArgs e)
        {
            if (InputTextValidator.CheckUsername(usernameTXT.Text,usernamecheckLBL)
                && InputTextValidator.CheckPassword(passwordTXT.Text, passwordcheckLBL))
            {
                if (!registered)
                {
                    await Database.AddAdmin(
                        usernameTXT.Text,
                        passwordTXT.Text);

                    registered = true;

                    usernameTXT.Text = "";
                    passwordTXT.Text = "";

                    rememberCHKBOX.Visible = true;

                    MessageBox.Show(
                        "Successfully Registered");

                    loginBTN.Text = "Login";
                }
                else if (registered)
                {
                    rememberCHKBOX.Visible = true;

                    if (await Database.LoginAdmin(usernameTXT.Text,passwordTXT.Text))
                       // ||(usernameTXT.Text == DataSeed.GetAdminUsername() && passwordTXT.Text == DataSeed.GetAdminPassword()))
                    {
                        this.Hide();

                        new MainInterface().ShowDialog();

                        this.Close();

                    }
                    else
                    {
                        usernameTXT.Text = "";
                        passwordTXT.Text = "";

                        MessageBox.Show(
                            "Invalid Credentials!");
                    }
                }
            }
        }

        private void cancelBTN_Click(
            object sender,
            EventArgs e)
        {
            Application.Exit();
        }

        private async void checkBox1_CheckedChanged(
            object sender,
            EventArgs e)
        {
            Database.wantsToRemember =
                rememberCHKBOX.Checked;

            await Database.UpdateRemember();
        }

        private void Form1_MouseDown(
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

        private void pictureBox1_Click(
            object sender,
            EventArgs e)
        {
        }

        private void pictureBox1_MouseDown(
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

        private void exitBTN_Click(
            object sender,
            EventArgs e)
        {
            Application.Exit();
        }

        private void passwordTXT_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loginBTN_Click(sender, e);
            }
        }

        private void Form1_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loginBTN_Click(sender, e);
            }
        }
    }
}