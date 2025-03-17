namespace EcoPoS_System
{
    partial class Administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PrincipalButton = new Button();
            AdmUsersButton = new Button();
            ChangePasswordButton = new Button();
            LogoutButton = new Button();
            AdminText = new Label();
            AdminLabel = new Label();
            pictureBox1 = new PictureBox();
            UserLabel = new Label();
            CodeLabel = new Label();
            UserText = new Label();
            CodeText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PrincipalButton
            // 
            PrincipalButton.Location = new Point(44, 283);
            PrincipalButton.Name = "PrincipalButton";
            PrincipalButton.Size = new Size(94, 29);
            PrincipalButton.TabIndex = 0;
            PrincipalButton.Text = "Principal";
            PrincipalButton.UseVisualStyleBackColor = true;
            PrincipalButton.Click += PrincipalButton_Click;
            // 
            // AdmUsersButton
            // 
            AdmUsersButton.Location = new Point(195, 283);
            AdmUsersButton.Name = "AdmUsersButton";
            AdmUsersButton.Size = new Size(119, 29);
            AdmUsersButton.TabIndex = 1;
            AdmUsersButton.Text = "Adm. Usuarios";
            AdmUsersButton.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordButton
            // 
            ChangePasswordButton.Location = new Point(366, 283);
            ChangePasswordButton.Name = "ChangePasswordButton";
            ChangePasswordButton.Size = new Size(161, 29);
            ChangePasswordButton.TabIndex = 2;
            ChangePasswordButton.Text = "Cambiar contraseña";
            ChangePasswordButton.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(571, 283);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(94, 29);
            LogoutButton.TabIndex = 3;
            LogoutButton.Text = "Cerrar Sesión";
            LogoutButton.UseVisualStyleBackColor = true;
            // 
            // AdminText
            // 
            AdminText.AutoSize = true;
            AdminText.BackColor = SystemColors.Control;
            AdminText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminText.ForeColor = SystemColors.ControlText;
            AdminText.Location = new Point(65, 53);
            AdminText.Name = "AdminText";
            AdminText.Size = new Size(116, 20);
            AdminText.TabIndex = 4;
            AdminText.Text = "Administrador:";
            AdminText.Click += AdminText_Click;
            // 
            // AdminLabel
            // 
            AdminLabel.BackColor = Color.Transparent;
            AdminLabel.BorderStyle = BorderStyle.Fixed3D;
            AdminLabel.Location = new Point(195, 53);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(186, 20);
            AdminLabel.TabIndex = 7;
            AdminLabel.Click += AdminLabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(502, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 117);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // UserLabel
            // 
            UserLabel.BackColor = Color.Transparent;
            UserLabel.BorderStyle = BorderStyle.Fixed3D;
            UserLabel.Location = new Point(195, 100);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(186, 20);
            UserLabel.TabIndex = 11;
            UserLabel.Click += UserLabel_Click;
            // 
            // CodeLabel
            // 
            CodeLabel.BackColor = Color.Transparent;
            CodeLabel.BorderStyle = BorderStyle.Fixed3D;
            CodeLabel.Location = new Point(195, 155);
            CodeLabel.Name = "CodeLabel";
            CodeLabel.Size = new Size(186, 20);
            CodeLabel.TabIndex = 12;
            CodeLabel.Click += CodeLabel_Click;
            // 
            // UserText
            // 
            UserText.AutoSize = true;
            UserText.BackColor = SystemColors.Control;
            UserText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserText.ForeColor = SystemColors.ControlText;
            UserText.Location = new Point(65, 100);
            UserText.Name = "UserText";
            UserText.Size = new Size(67, 20);
            UserText.TabIndex = 13;
            UserText.Text = "Usuario:";
            UserText.Click += UserText_Click;
            // 
            // CodeText
            // 
            CodeText.AutoSize = true;
            CodeText.BackColor = SystemColors.Control;
            CodeText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CodeText.ForeColor = SystemColors.ControlText;
            CodeText.Location = new Point(65, 155);
            CodeText.Name = "CodeText";
            CodeText.Size = new Size(62, 20);
            CodeText.TabIndex = 14;
            CodeText.Text = "Código:";
            CodeText.Click += CodeText_Click;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 346);
            Controls.Add(CodeText);
            Controls.Add(UserText);
            Controls.Add(CodeLabel);
            Controls.Add(UserLabel);
            Controls.Add(pictureBox1);
            Controls.Add(AdminLabel);
            Controls.Add(AdminText);
            Controls.Add(LogoutButton);
            Controls.Add(ChangePasswordButton);
            Controls.Add(AdmUsersButton);
            Controls.Add(PrincipalButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Administrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            FormClosed += Administrador_FormClosed;
            Load += Administrador_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PrincipalButton;
        private Button AdmUsersButton;
        private Button ChangePasswordButton;
        private Button LogoutButton;
        private Label AdminText;
        private Label AdminLabel;
        private PictureBox pictureBox1;
        private Label UserLabel;
        private Label CodeLabel;
        private Label UserText;
        private Label CodeText;
    }
}