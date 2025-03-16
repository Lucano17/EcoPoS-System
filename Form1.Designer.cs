namespace EcoPoS_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginButton = new Button();
            ExitButton = new Button();
            UserLabel = new Label();
            UserPassword = new Label();
            UserTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(206, 181);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Igresar";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(66, 181);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Salir";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(25, 58);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(63, 20);
            UserLabel.TabIndex = 2;
            UserLabel.Text = "Usuario";
            // 
            // UserPassword
            // 
            UserPassword.AutoSize = true;
            UserPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserPassword.Location = new Point(25, 114);
            UserPassword.Name = "UserPassword";
            UserPassword.Size = new Size(88, 20);
            UserPassword.TabIndex = 3;
            UserPassword.Text = "Contraseña";
            // 
            // UserTextBox
            // 
            UserTextBox.Location = new Point(138, 55);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(162, 27);
            UserTextBox.TabIndex = 4;
            UserTextBox.TextChanged += UserTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(138, 111);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(162, 27);
            PasswordTextBox.TabIndex = 5;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserTextBox);
            Controls.Add(UserPassword);
            Controls.Add(UserLabel);
            Controls.Add(ExitButton);
            Controls.Add(LoginButton);
            MaximumSize = new Size(400, 300);
            MinimumSize = new Size(400, 300);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eco PoS - System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private Button ExitButton;
        private Label UserLabel;
        private Label UserPassword;
        private TextBox UserTextBox;
        private TextBox PasswordTextBox;
    }
}
