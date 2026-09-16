namespace InventoryDesktopApp
{
    partial class LoginInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            usernameTXT = new TextBox();
            passwordTXT = new TextBox();
            usernameLBL = new Label();
            passwordLBL = new Label();
            loginBTN = new Button();
            passwordcheckLBL = new Label();
            usernamecheckLBL = new Label();
            rememberCHKBOX = new CheckBox();
            exitBTN = new Button();
            brandPanel = new Panel();
            appTitleLBL = new Label();
            appSubtitleLBL = new Label();
            accentLineLBL = new Label();
            appDescriptionLBL = new Label();
            loginPanel = new Panel();
            welcomeLBL = new Label();
            signInLBL = new Label();
            brandPanel.SuspendLayout();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTXT
            // 
            usernameTXT.BackColor = Color.FromArgb(37, 42, 64);
            usernameTXT.BorderStyle = BorderStyle.FixedSingle;
            usernameTXT.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTXT.ForeColor = Color.White;
            usernameTXT.Location = new Point(35, 205);
            usernameTXT.Name = "usernameTXT";
            usernameTXT.Size = new Size(320, 25);
            usernameTXT.TabIndex = 0;
            // 
            // passwordTXT
            // 
            passwordTXT.BackColor = Color.FromArgb(37, 42, 64);
            passwordTXT.BorderStyle = BorderStyle.FixedSingle;
            passwordTXT.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTXT.ForeColor = Color.White;
            passwordTXT.Location = new Point(35, 265);
            passwordTXT.Name = "passwordTXT";
            passwordTXT.PasswordChar = '*';
            passwordTXT.Size = new Size(320, 25);
            passwordTXT.TabIndex = 1;
            passwordTXT.KeyPress += passwordTXT_KeyPress;
            // 
            // usernameLBL
            // 
            usernameLBL.AutoSize = true;
            usernameLBL.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLBL.ForeColor = Color.FromArgb(167, 174, 196);
            usernameLBL.Location = new Point(35, 180);
            usernameLBL.Name = "usernameLBL";
            usernameLBL.Size = new Size(74, 19);
            usernameLBL.TabIndex = 6;
            usernameLBL.Text = "Username:";
            // 
            // passwordLBL
            // 
            passwordLBL.AutoSize = true;
            passwordLBL.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLBL.ForeColor = Color.FromArgb(167, 174, 196);
            passwordLBL.Location = new Point(35, 240);
            passwordLBL.Name = "passwordLBL";
            passwordLBL.Size = new Size(70, 19);
            passwordLBL.TabIndex = 7;
            passwordLBL.Text = "Password:";
            // 
            // loginBTN
            // 
            loginBTN.BackColor = Color.FromArgb(124, 92, 252);
            loginBTN.FlatAppearance.BorderSize = 0;
            loginBTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(108, 76, 230);
            loginBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(146, 120, 255);
            loginBTN.FlatStyle = FlatStyle.Flat;
            loginBTN.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            loginBTN.ForeColor = Color.White;
            loginBTN.Location = new Point(35, 330);
            loginBTN.Name = "loginBTN";
            loginBTN.Size = new Size(320, 45);
            loginBTN.TabIndex = 2;
            loginBTN.Text = "Login";
            loginBTN.UseVisualStyleBackColor = false;
            loginBTN.Click += loginBTN_Click;
            // 
            // passwordcheckLBL
            // 
            passwordcheckLBL.AutoSize = true;
            passwordcheckLBL.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            passwordcheckLBL.ForeColor = Color.FromArgb(255, 92, 112);
            passwordcheckLBL.Location = new Point(35, 397);
            passwordcheckLBL.Name = "passwordcheckLBL";
            passwordcheckLBL.Size = new Size(272, 15);
            passwordcheckLBL.TabIndex = 9;
            passwordcheckLBL.Text = "Your password should be at least 6 characters long";
            passwordcheckLBL.Visible = false;
            // 
            // usernamecheckLBL
            // 
            usernamecheckLBL.AutoSize = true;
            usernamecheckLBL.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            usernamecheckLBL.ForeColor = Color.FromArgb(255, 92, 112);
            usernamecheckLBL.Location = new Point(35, 380);
            usernamecheckLBL.Name = "usernamecheckLBL";
            usernamecheckLBL.Size = new Size(97, 15);
            usernamecheckLBL.TabIndex = 8;
            usernamecheckLBL.Text = "Invalid username";
            usernamecheckLBL.Visible = false;
            // 
            // rememberCHKBOX
            // 
            rememberCHKBOX.AutoSize = true;
            rememberCHKBOX.BackColor = Color.FromArgb(32, 36, 58);
            rememberCHKBOX.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rememberCHKBOX.ForeColor = Color.FromArgb(167, 174, 196);
            rememberCHKBOX.Location = new Point(35, 300);
            rememberCHKBOX.Name = "rememberCHKBOX";
            rememberCHKBOX.Size = new Size(139, 19);
            rememberCHKBOX.TabIndex = 5;
            rememberCHKBOX.Text = "Remember username";
            rememberCHKBOX.UseVisualStyleBackColor = false;
            rememberCHKBOX.Visible = false;
            rememberCHKBOX.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // exitBTN
            // 
            exitBTN.BackColor = Color.FromArgb(23, 26, 43);
            exitBTN.FlatAppearance.BorderSize = 0;
            exitBTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 70, 90);
            exitBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 92, 112);
            exitBTN.FlatStyle = FlatStyle.Flat;
            exitBTN.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            exitBTN.ForeColor = Color.FromArgb(167, 174, 196);
            exitBTN.Location = new Point(855, 10);
            exitBTN.Margin = new Padding(0);
            exitBTN.Name = "exitBTN";
            exitBTN.Size = new Size(35, 35);
            exitBTN.TabIndex = 6;
            exitBTN.Text = "×";
            exitBTN.UseVisualStyleBackColor = false;
            exitBTN.Click += exitBTN_Click;
            // 
            // brandPanel
            // 
            brandPanel.BackColor = Color.FromArgb(20, 23, 40);
            brandPanel.Controls.Add(appTitleLBL);
            brandPanel.Controls.Add(appSubtitleLBL);
            brandPanel.Controls.Add(accentLineLBL);
            brandPanel.Controls.Add(appDescriptionLBL);
            brandPanel.Location = new Point(0, 0);
            brandPanel.Name = "brandPanel";
            brandPanel.Size = new Size(390, 550);
            brandPanel.TabIndex = 0;
            brandPanel.MouseDown += Form1_MouseDown;
            // 
            // appTitleLBL
            // 
            appTitleLBL.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            appTitleLBL.ForeColor = Color.FromArgb(255, 255, 255);
            appTitleLBL.Location = new Point(55, 235);
            appTitleLBL.Name = "appTitleLBL";
            appTitleLBL.Size = new Size(280, 50);
            appTitleLBL.TabIndex = 0;
            appTitleLBL.Text = "Inventory";
            appTitleLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // appSubtitleLBL
            // 
            appSubtitleLBL.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            appSubtitleLBL.ForeColor = Color.FromArgb(167, 174, 196);
            appSubtitleLBL.Location = new Point(45, 285);
            appSubtitleLBL.Name = "appSubtitleLBL";
            appSubtitleLBL.Size = new Size(300, 35);
            appSubtitleLBL.TabIndex = 1;
            appSubtitleLBL.Text = "Management System";
            appSubtitleLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // accentLineLBL
            // 
            accentLineLBL.BackColor = Color.FromArgb(124, 92, 252);
            accentLineLBL.Location = new Point(165, 330);
            accentLineLBL.Name = "accentLineLBL";
            accentLineLBL.Size = new Size(60, 4);
            accentLineLBL.TabIndex = 2;
            // 
            // appDescriptionLBL
            // 
            appDescriptionLBL.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            appDescriptionLBL.ForeColor = Color.FromArgb(167, 174, 196);
            appDescriptionLBL.Location = new Point(45, 350);
            appDescriptionLBL.Name = "appDescriptionLBL";
            appDescriptionLBL.Size = new Size(300, 60);
            appDescriptionLBL.TabIndex = 3;
            appDescriptionLBL.Text = "Manage your products,\r\ntrack your stock, grow your business.";
            appDescriptionLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.FromArgb(32, 36, 58);
            loginPanel.Controls.Add(welcomeLBL);
            loginPanel.Controls.Add(signInLBL);
            loginPanel.Controls.Add(usernameLBL);
            loginPanel.Controls.Add(usernameTXT);
            loginPanel.Controls.Add(passwordLBL);
            loginPanel.Controls.Add(passwordTXT);
            loginPanel.Controls.Add(rememberCHKBOX);
            loginPanel.Controls.Add(loginBTN);
            loginPanel.Controls.Add(usernamecheckLBL);
            loginPanel.Controls.Add(passwordcheckLBL);
            loginPanel.Location = new Point(455, 65);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(390, 420);
            loginPanel.TabIndex = 1;
            // 
            // welcomeLBL
            // 
            welcomeLBL.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeLBL.ForeColor = Color.White;
            welcomeLBL.Location = new Point(30, 68);
            welcomeLBL.Name = "welcomeLBL";
            welcomeLBL.Size = new Size(330, 40);
            welcomeLBL.TabIndex = 4;
            welcomeLBL.Text = "Welcome back";
            welcomeLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signInLBL
            // 
            signInLBL.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            signInLBL.ForeColor = Color.FromArgb(167, 174, 196);
            signInLBL.Location = new Point(30, 121);
            signInLBL.Name = "signInLBL";
            signInLBL.Size = new Size(330, 25);
            signInLBL.TabIndex = 5;
            signInLBL.Text = "Sign in to your account";
            signInLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 26, 43);
            ClientSize = new Size(900, 550);
            Controls.Add(brandPanel);
            Controls.Add(loginPanel);
            Controls.Add(exitBTN);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximumSize = new Size(900, 550);
            MinimumSize = new Size(900, 550);
            Name = "LoginInterface";
            Text = "User Authentication";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            MouseDown += Form1_MouseDown;
            brandPanel.ResumeLayout(false);
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox usernameTXT;
        private TextBox passwordTXT;

        private Label usernameLBL;
        private Label passwordLBL;

        private Button loginBTN;

        private Label passwordcheckLBL;
        private Label usernamecheckLBL;

        private CheckBox rememberCHKBOX;

        private Button exitBTN;

        private Panel brandPanel;
        private Panel loginPanel;

        private Label appTitleLBL;
        private Label appSubtitleLBL;
        private Label appDescriptionLBL;

        private Label welcomeLBL;
        private Label signInLBL;
        private Label accentLineLBL;
    }
}