namespace EcoPoS_System
{
    partial class Mantenimiento_Clientes
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
            ClientLastNameTextBox = new TextBox();
            ClientNameTextBox = new TextBox();
            ClientIDTextBox = new TextBox();
            ClientLastNameLabel = new Label();
            ClientNameLabel = new Label();
            ClientIDLabel = new Label();
            SuspendLayout();
            // 
            // RequestButton
            // 
            RequestButton.Click += RequestButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Click += SaveButton_Click;
            // 
            // NewButton
            // 
            NewButton.Click += NewButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(616, 389);
            // 
            // ClientLastNameTextBox
            // 
            ClientLastNameTextBox.Location = new Point(211, 206);
            ClientLastNameTextBox.Name = "ClientLastNameTextBox";
            ClientLastNameTextBox.Size = new Size(191, 27);
            ClientLastNameTextBox.TabIndex = 15;
            ClientLastNameTextBox.TextChanged += ClientLastNameTextBox_TextChanged;
            // 
            // ClientNameTextBox
            // 
            ClientNameTextBox.Location = new Point(211, 143);
            ClientNameTextBox.Name = "ClientNameTextBox";
            ClientNameTextBox.Size = new Size(191, 27);
            ClientNameTextBox.TabIndex = 14;
            ClientNameTextBox.TextChanged += ClientNameTextBox_TextChanged;
            // 
            // ClientIDTextBox
            // 
            ClientIDTextBox.Location = new Point(211, 89);
            ClientIDTextBox.Name = "ClientIDTextBox";
            ClientIDTextBox.Size = new Size(191, 27);
            ClientIDTextBox.TabIndex = 13;
            ClientIDTextBox.TextChanged += ClientIDTextBox_TextChanged;
            // 
            // ClientLastNameLabel
            // 
            ClientLastNameLabel.AutoSize = true;
            ClientLastNameLabel.Location = new Point(42, 213);
            ClientLastNameLabel.Name = "ClientLastNameLabel";
            ClientLastNameLabel.Size = new Size(142, 20);
            ClientLastNameLabel.TabIndex = 12;
            ClientLastNameLabel.Text = "Apellido del cliente:";
            ClientLastNameLabel.Click += ClientLastNameLabel_Click;
            // 
            // ClientNameLabel
            // 
            ClientNameLabel.AutoSize = true;
            ClientNameLabel.Location = new Point(42, 150);
            ClientNameLabel.Name = "ClientNameLabel";
            ClientNameLabel.Size = new Size(140, 20);
            ClientNameLabel.TabIndex = 11;
            ClientNameLabel.Text = "Nombre del cliente:";
            ClientNameLabel.Click += ClientNameLabel_Click;
            // 
            // ClientIDLabel
            // 
            ClientIDLabel.AutoSize = true;
            ClientIDLabel.Location = new Point(42, 92);
            ClientIDLabel.Name = "ClientIDLabel";
            ClientIDLabel.Size = new Size(100, 20);
            ClientIDLabel.TabIndex = 10;
            ClientIDLabel.Text = "ID del cliente:";
            ClientIDLabel.Click += ClientIDLabel_Click;
            // 
            // Mantenimiento_Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClientLastNameTextBox);
            Controls.Add(ClientNameTextBox);
            Controls.Add(ClientIDTextBox);
            Controls.Add(ClientLastNameLabel);
            Controls.Add(ClientNameLabel);
            Controls.Add(ClientIDLabel);
            Name = "Mantenimiento_Clientes";
            Text = "Mantenimiento de clientes";
            WindowState = FormWindowState.Maximized;
            Load += Mantenimiento_Clientes_Load;
            Controls.SetChildIndex(RequestButton, 0);
            Controls.SetChildIndex(SaveButton, 0);
            Controls.SetChildIndex(NewButton, 0);
            Controls.SetChildIndex(DeleteButton, 0);
            Controls.SetChildIndex(ExitButton, 0);
            Controls.SetChildIndex(ClientIDLabel, 0);
            Controls.SetChildIndex(ClientNameLabel, 0);
            Controls.SetChildIndex(ClientLastNameLabel, 0);
            Controls.SetChildIndex(ClientIDTextBox, 0);
            Controls.SetChildIndex(ClientNameTextBox, 0);
            Controls.SetChildIndex(ClientLastNameTextBox, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ClientLastNameTextBox;
        private TextBox ClientNameTextBox;
        private TextBox ClientIDTextBox;
        private Label ClientLastNameLabel;
        private Label ClientNameLabel;
        private Label ClientIDLabel;
    }
}