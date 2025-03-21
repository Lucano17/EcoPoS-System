namespace EcoPoS_System
{
    partial class Facturacion
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
            SearchButton = new Button();
            ClientsButton = new Button();
            ProductsButton = new Button();
            DeleteButton = new Button();
            SetButton = new Button();
            BillButton = new Button();
            TextLabel1 = new Label();
            TextLabel2 = new Label();
            SellerLabel = new Label();
            TextLabel3 = new Label();
            PriceTextBox = new TextBox();
            ProductCodeTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            TotalPriceLabel = new Label();
            label1 = new Label();
            ClientLabel = new Label();
            ClientCodeTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Descripción = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Importe = new DataGridViewTextBoxColumn();
            SetNewButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(908, 659);
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(382, 133);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Buscar";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // ClientsButton
            // 
            ClientsButton.Location = new Point(508, 209);
            ClientsButton.Name = "ClientsButton";
            ClientsButton.Size = new Size(94, 29);
            ClientsButton.TabIndex = 2;
            ClientsButton.Text = "Clientes";
            ClientsButton.UseVisualStyleBackColor = true;
            ClientsButton.Click += ClientsButton_Click;
            // 
            // ProductsButton
            // 
            ProductsButton.Location = new Point(608, 209);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(94, 29);
            ProductsButton.TabIndex = 3;
            ProductsButton.Text = "Productos";
            ProductsButton.UseVisualStyleBackColor = true;
            ProductsButton.Click += ProductsButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(808, 209);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Eliminar";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SetButton
            // 
            SetButton.Location = new Point(708, 209);
            SetButton.Name = "SetButton";
            SetButton.Size = new Size(94, 29);
            SetButton.TabIndex = 5;
            SetButton.Text = "Colocar";
            SetButton.UseVisualStyleBackColor = true;
            SetButton.Click += SetButton_Click;
            // 
            // BillButton
            // 
            BillButton.Location = new Point(908, 244);
            BillButton.Name = "BillButton";
            BillButton.Size = new Size(94, 29);
            BillButton.TabIndex = 6;
            BillButton.Text = "Facturar";
            BillButton.UseVisualStyleBackColor = true;
            BillButton.Click += BillButton_Click;
            // 
            // TextLabel1
            // 
            TextLabel1.AutoSize = true;
            TextLabel1.Location = new Point(41, 92);
            TextLabel1.Name = "TextLabel1";
            TextLabel1.Size = new Size(76, 20);
            TextLabel1.TabIndex = 7;
            TextLabel1.Text = "Vendedor:";
            // 
            // TextLabel2
            // 
            TextLabel2.AutoSize = true;
            TextLabel2.Location = new Point(41, 133);
            TextLabel2.Name = "TextLabel2";
            TextLabel2.Size = new Size(134, 20);
            TextLabel2.TabIndex = 10;
            TextLabel2.Text = "Código del cliente:";
            // 
            // SellerLabel
            // 
            SellerLabel.BackColor = SystemColors.ButtonHighlight;
            SellerLabel.BorderStyle = BorderStyle.Fixed3D;
            SellerLabel.Location = new Point(181, 91);
            SellerLabel.Name = "SellerLabel";
            SellerLabel.Size = new Size(174, 25);
            SellerLabel.TabIndex = 12;
            SellerLabel.Click += SellerLabel_Click;
            // 
            // TextLabel3
            // 
            TextLabel3.AutoSize = true;
            TextLabel3.Location = new Point(41, 172);
            TextLabel3.Name = "TextLabel3";
            TextLabel3.Size = new Size(58, 20);
            TextLabel3.TabIndex = 13;
            TextLabel3.Text = "Cliente:";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(579, 279);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(135, 27);
            PriceTextBox.TabIndex = 16;
            PriceTextBox.TextChanged += PriceTextBox_TextChanged;
            // 
            // ProductCodeTextBox
            // 
            ProductCodeTextBox.Location = new Point(95, 279);
            ProductCodeTextBox.Name = "ProductCodeTextBox";
            ProductCodeTextBox.Size = new Size(151, 27);
            ProductCodeTextBox.TabIndex = 17;
            ProductCodeTextBox.TextChanged += ProductCodeTextBox_TextChanged;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(743, 279);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(82, 27);
            QuantityTextBox.TabIndex = 18;
            QuantityTextBox.TextChanged += QuantityTextBox_TextChanged;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(269, 279);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(287, 27);
            DescriptionTextBox.TabIndex = 20;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(508, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(494, 185);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPriceLabel.ForeColor = SystemColors.ControlText;
            TotalPriceLabel.Location = new Point(792, 603);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(210, 41);
            TotalPriceLabel.TabIndex = 28;
            TotalPriceLabel.Text = "$";
            TotalPriceLabel.Click += TotalPriceLabel_Click_1;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(677, 603);
            label1.Name = "label1";
            label1.Size = new Size(125, 41);
            label1.TabIndex = 29;
            label1.Text = "TOTAL:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // ClientLabel
            // 
            ClientLabel.BackColor = SystemColors.ButtonHighlight;
            ClientLabel.BorderStyle = BorderStyle.Fixed3D;
            ClientLabel.Location = new Point(181, 171);
            ClientLabel.Name = "ClientLabel";
            ClientLabel.Size = new Size(174, 25);
            ClientLabel.TabIndex = 31;
            ClientLabel.Click += ClientLabel_Click;
            // 
            // ClientCodeTextBox
            // 
            ClientCodeTextBox.Location = new Point(181, 133);
            ClientCodeTextBox.Name = "ClientCodeTextBox";
            ClientCodeTextBox.Size = new Size(174, 27);
            ClientCodeTextBox.TabIndex = 32;
            ClientCodeTextBox.TextChanged += ClientCodeTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 256);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 33;
            label3.Text = "Código del producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 256);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 34;
            label4.Text = "Descripción:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(620, 256);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 35;
            label5.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(743, 256);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 36;
            label6.Text = "Cantidad:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Código, Descripción, Precio, Cantidad, Importe });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(83, 312);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(919, 272);
            dataGridView1.TabIndex = 37;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.MinimumWidth = 6;
            Código.Name = "Código";
            Código.Width = 175;
            // 
            // Descripción
            // 
            Descripción.HeaderText = "Descripción";
            Descripción.MinimumWidth = 6;
            Descripción.Name = "Descripción";
            Descripción.Width = 317;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // Importe
            // 
            Importe.HeaderText = "Importe";
            Importe.MinimumWidth = 6;
            Importe.Name = "Importe";
            Importe.Width = 150;
            // 
            // SetNewButton
            // 
            SetNewButton.Location = new Point(908, 209);
            SetNewButton.Name = "SetNewButton";
            SetNewButton.Size = new Size(94, 29);
            SetNewButton.TabIndex = 38;
            SetNewButton.Text = "Nuevo";
            SetNewButton.UseVisualStyleBackColor = true;
            SetNewButton.Click += SetNewButton_Click;
            // 
            // Facturacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 700);
            Controls.Add(SetNewButton);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ClientCodeTextBox);
            Controls.Add(ClientLabel);
            Controls.Add(label1);
            Controls.Add(TotalPriceLabel);
            Controls.Add(pictureBox1);
            Controls.Add(DescriptionTextBox);
            Controls.Add(QuantityTextBox);
            Controls.Add(ProductCodeTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(TextLabel3);
            Controls.Add(SellerLabel);
            Controls.Add(TextLabel2);
            Controls.Add(TextLabel1);
            Controls.Add(BillButton);
            Controls.Add(SetButton);
            Controls.Add(DeleteButton);
            Controls.Add(ProductsButton);
            Controls.Add(ClientsButton);
            Controls.Add(SearchButton);
            Name = "Facturacion";
            Text = "Facturacion";
            Load += Facturacion_Load;
            Controls.SetChildIndex(ExitButton, 0);
            Controls.SetChildIndex(SearchButton, 0);
            Controls.SetChildIndex(ClientsButton, 0);
            Controls.SetChildIndex(ProductsButton, 0);
            Controls.SetChildIndex(DeleteButton, 0);
            Controls.SetChildIndex(SetButton, 0);
            Controls.SetChildIndex(BillButton, 0);
            Controls.SetChildIndex(TextLabel1, 0);
            Controls.SetChildIndex(TextLabel2, 0);
            Controls.SetChildIndex(SellerLabel, 0);
            Controls.SetChildIndex(TextLabel3, 0);
            Controls.SetChildIndex(PriceTextBox, 0);
            Controls.SetChildIndex(ProductCodeTextBox, 0);
            Controls.SetChildIndex(QuantityTextBox, 0);
            Controls.SetChildIndex(DescriptionTextBox, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(TotalPriceLabel, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(ClientLabel, 0);
            Controls.SetChildIndex(ClientCodeTextBox, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(SetNewButton, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private Button ClientsButton;
        private Button ProductsButton;
        private Button DeleteButton;
        private Button SetButton;
        private Button BillButton;
        private Label TextLabel1;
        private Label TextLabel2;
        private Label SellerLabel;
        private Label TextLabel3;
        private TextBox PriceTextBox;
        private TextBox ProductCodeTextBox;
        private TextBox QuantityTextBox;
        private TextBox DescriptionTextBox;
        private PictureBox pictureBox1;
        private Label TotalPriceLabel;
        private Label label1;
        private Label ClientLabel;
        private TextBox ClientCodeTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Descripción;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Importe;
        private Button SetNewButton;
    }
}