namespace EcoPoS_System
{
    partial class Usuario
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
            CodeText = new Label();
            UserText = new Label();
            CodeLabel = new Label();
            UserLabel = new Label();
            pictureBox1 = new PictureBox();
            NameLabel = new Label();
            NameText = new Label();
            LogoutButton = new Button();
            ChangePasswordButton = new Button();
            AdmUsersButton = new Button();
            PrincipalButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CodeText
            // 
            CodeText.AutoSize = true;
            CodeText.BackColor = SystemColors.Control;
            CodeText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CodeText.ForeColor = SystemColors.ControlText;
            CodeText.Location = new Point(80, 145);
            CodeText.Name = "CodeText";
            CodeText.Size = new Size(62, 20);
            CodeText.TabIndex = 25;
            CodeText.Text = "Código:";
            // 
            // UserText
            // 
            UserText.AutoSize = true;
            UserText.BackColor = SystemColors.Control;
            UserText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserText.ForeColor = SystemColors.ControlText;
            UserText.Location = new Point(80, 90);
            UserText.Name = "UserText";
            UserText.Size = new Size(67, 20);
            UserText.TabIndex = 24;
            UserText.Text = "Usuario:";
            // 
            // CodeLabel
            // 
            CodeLabel.BackColor = Color.Transparent;
            CodeLabel.BorderStyle = BorderStyle.Fixed3D;
            CodeLabel.Location = new Point(210, 145);
            CodeLabel.Name = "CodeLabel";
            CodeLabel.Size = new Size(186, 20);
            CodeLabel.TabIndex = 23;
            // 
            // UserLabel
            // 
            UserLabel.BackColor = Color.Transparent;
            UserLabel.BorderStyle = BorderStyle.Fixed3D;
            UserLabel.Location = new Point(210, 90);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(186, 20);
            UserLabel.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(517, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // NameLabel
            // 
            NameLabel.BackColor = Color.Transparent;
            NameLabel.BorderStyle = BorderStyle.Fixed3D;
            NameLabel.Location = new Point(210, 43);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(186, 20);
            NameLabel.TabIndex = 20;
            // 
            // NameText
            // 
            NameText.AutoSize = true;
            NameText.BackColor = SystemColors.Control;
            NameText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameText.ForeColor = SystemColors.ControlText;
            NameText.Location = new Point(80, 43);
            NameText.Name = "NameText";
            NameText.Size = new Size(71, 20);
            NameText.TabIndex = 19;
            NameText.Text = "Nombre:";
            NameText.Click += NameText_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(586, 273);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(94, 29);
            LogoutButton.TabIndex = 18;
            LogoutButton.Text = "Cerrar Sesión";
            LogoutButton.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordButton
            // 
            ChangePasswordButton.Location = new Point(381, 273);
            ChangePasswordButton.Name = "ChangePasswordButton";
            ChangePasswordButton.Size = new Size(161, 29);
            ChangePasswordButton.TabIndex = 17;
            ChangePasswordButton.Text = "Cambiar contraseña";
            ChangePasswordButton.UseVisualStyleBackColor = true;
            // 
            // AdmUsersButton
            // 
            AdmUsersButton.Location = new Point(210, 273);
            AdmUsersButton.Name = "AdmUsersButton";
            AdmUsersButton.Size = new Size(119, 29);
            AdmUsersButton.TabIndex = 16;
            AdmUsersButton.Text = "Adm. Usuarios";
            AdmUsersButton.UseVisualStyleBackColor = true;
            // 
            // PrincipalButton
            // 
            PrincipalButton.Location = new Point(59, 273);
            PrincipalButton.Name = "PrincipalButton";
            PrincipalButton.Size = new Size(94, 29);
            PrincipalButton.TabIndex = 15;
            PrincipalButton.Text = "Principal";
            PrincipalButton.UseVisualStyleBackColor = true;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 345);
            Controls.Add(CodeText);
            Controls.Add(UserText);
            Controls.Add(CodeLabel);
            Controls.Add(UserLabel);
            Controls.Add(pictureBox1);
            Controls.Add(NameLabel);
            Controls.Add(NameText);
            Controls.Add(LogoutButton);
            Controls.Add(ChangePasswordButton);
            Controls.Add(AdmUsersButton);
            Controls.Add(PrincipalButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuario";
            FormClosed += Usuario_FormClosed;
            Load += Usuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CodeText;
        private Label UserText;
        private Label CodeLabel;
        private Label UserLabel;
        private PictureBox pictureBox1;
        private Label NameLabel;
        private Label NameText;
        private Button LogoutButton;
        private Button ChangePasswordButton;
        private Button AdmUsersButton;
        private Button PrincipalButton;
    }
}