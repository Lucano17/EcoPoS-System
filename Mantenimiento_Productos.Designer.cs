namespace EcoPoS_System
{
    partial class Mantenimiento_Productos
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
            ProductIDLabel = new Label();
            ProductNameLabel = new Label();
            ProductPriceLabel = new Label();
            ProductIDTextBox = new TextBox();
            ProductNameTextBox = new TextBox();
            ProductPriceTextBox = new TextBox();
            SuspendLayout();
            // 
            // RequestButton
            // 
            RequestButton.Location = new Point(40, 328);
            RequestButton.Click += RequestButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(324, 328);
            SaveButton.Click += SaveButton_Click;
            // 
            // NewButton
            // 
            NewButton.Location = new Point(186, 328);
            NewButton.Click += NewButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(479, 328);
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(633, 328);
            // 
            // ProductIDLabel
            // 
            ProductIDLabel.AutoSize = true;
            ProductIDLabel.Location = new Point(84, 93);
            ProductIDLabel.Name = "ProductIDLabel";
            ProductIDLabel.Size = new Size(114, 20);
            ProductIDLabel.TabIndex = 4;
            ProductIDLabel.Text = "ID del producto";
            ProductIDLabel.Click += ProductIDLabel_Click;
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Location = new Point(84, 151);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(154, 20);
            ProductNameLabel.TabIndex = 5;
            ProductNameLabel.Text = "Nombre del producto";
            ProductNameLabel.Click += ProductNameLabel_Click;
            // 
            // ProductPriceLabel
            // 
            ProductPriceLabel.AutoSize = true;
            ProductPriceLabel.Location = new Point(84, 214);
            ProductPriceLabel.Name = "ProductPriceLabel";
            ProductPriceLabel.Size = new Size(140, 20);
            ProductPriceLabel.TabIndex = 6;
            ProductPriceLabel.Text = "Precio del producto";
            ProductPriceLabel.Click += ProductPriceLabel_Click;
            // 
            // ProductIDTextBox
            // 
            ProductIDTextBox.Location = new Point(293, 90);
            ProductIDTextBox.Name = "ProductIDTextBox";
            ProductIDTextBox.Size = new Size(191, 27);
            ProductIDTextBox.TabIndex = 7;
            ProductIDTextBox.TextChanged += ProductIDTextBox_TextChanged;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(293, 148);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(191, 27);
            ProductNameTextBox.TabIndex = 8;
            ProductNameTextBox.TextChanged += ProductNameTextBox_TextChanged;
            // 
            // ProductPriceTextBox
            // 
            ProductPriceTextBox.Location = new Point(293, 211);
            ProductPriceTextBox.Name = "ProductPriceTextBox";
            ProductPriceTextBox.Size = new Size(191, 27);
            ProductPriceTextBox.TabIndex = 9;
            ProductPriceTextBox.TextChanged += ProductPriceTextBox_TextChanged;
            // 
            // Mantenimiento_Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 394);
            Controls.Add(ProductPriceTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(ProductIDTextBox);
            Controls.Add(ProductPriceLabel);
            Controls.Add(ProductNameLabel);
            Controls.Add(ProductIDLabel);
            Name = "Mantenimiento_Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento_Productos";
            WindowState = FormWindowState.Maximized;
            Load += Mantenimiento_Productos_Load;
            Controls.SetChildIndex(RequestButton, 0);
            Controls.SetChildIndex(SaveButton, 0);
            Controls.SetChildIndex(NewButton, 0);
            Controls.SetChildIndex(DeleteButton, 0);
            Controls.SetChildIndex(ExitButton, 0);
            Controls.SetChildIndex(ProductIDLabel, 0);
            Controls.SetChildIndex(ProductNameLabel, 0);
            Controls.SetChildIndex(ProductPriceLabel, 0);
            Controls.SetChildIndex(ProductIDTextBox, 0);
            Controls.SetChildIndex(ProductNameTextBox, 0);
            Controls.SetChildIndex(ProductPriceTextBox, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProductIDLabel;
        private Label ProductNameLabel;
        private Label ProductPriceLabel;
        private TextBox ProductIDTextBox;
        private TextBox ProductNameTextBox;
        private TextBox ProductPriceTextBox;
    }
}