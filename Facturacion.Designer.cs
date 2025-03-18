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
            GridCodeLabel = new Label();
            TextLabel2 = new Label();
            SellerLabel = new Label();
            TextLabel3 = new Label();
            PriceTextBox = new TextBox();
            ProductCodeTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            GridDescriptionLabel = new Label();
            GridPriceLabel = new Label();
            GridQuantityLabel = new Label();
            label2 = new Label();
            TotalPriceLabel = new Label();
            label1 = new Label();
            ClientLabel = new Label();
            ClientCodeTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(908, 659);
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(340, 129);
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
            // 
            // ProductsButton
            // 
            ProductsButton.Location = new Point(608, 209);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(94, 29);
            ProductsButton.TabIndex = 3;
            ProductsButton.Text = "Productos";
            ProductsButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(708, 209);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Eliminar";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // SetButton
            // 
            SetButton.Location = new Point(808, 209);
            SetButton.Name = "SetButton";
            SetButton.Size = new Size(94, 29);
            SetButton.TabIndex = 5;
            SetButton.Text = "Colocar";
            SetButton.UseVisualStyleBackColor = true;
            // 
            // BillButton
            // 
            BillButton.Location = new Point(908, 209);
            BillButton.Name = "BillButton";
            BillButton.Size = new Size(94, 29);
            BillButton.TabIndex = 6;
            BillButton.Text = "Facturar";
            BillButton.UseVisualStyleBackColor = true;
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
            // GridCodeLabel
            // 
            GridCodeLabel.BackColor = SystemColors.ActiveCaption;
            GridCodeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GridCodeLabel.ForeColor = SystemColors.ControlLightLight;
            GridCodeLabel.Location = new Point(34, 312);
            GridCodeLabel.Name = "GridCodeLabel";
            GridCodeLabel.Size = new Size(194, 41);
            GridCodeLabel.TabIndex = 8;
            GridCodeLabel.Text = "Código";
            GridCodeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextLabel2
            // 
            TextLabel2.AutoSize = true;
            TextLabel2.Location = new Point(41, 133);
            TextLabel2.Name = "TextLabel2";
            TextLabel2.Size = new Size(61, 20);
            TextLabel2.TabIndex = 10;
            TextLabel2.Text = "Código:";
            // 
            // SellerLabel
            // 
            SellerLabel.BackColor = SystemColors.ButtonHighlight;
            SellerLabel.BorderStyle = BorderStyle.Fixed3D;
            SellerLabel.Location = new Point(139, 87);
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
            PriceTextBox.Location = new Point(535, 279);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(125, 27);
            PriceTextBox.TabIndex = 16;
            // 
            // ProductCodeTextBox
            // 
            ProductCodeTextBox.Location = new Point(41, 279);
            ProductCodeTextBox.Name = "ProductCodeTextBox";
            ProductCodeTextBox.Size = new Size(187, 27);
            ProductCodeTextBox.TabIndex = 17;
            ProductCodeTextBox.TextChanged += ProductCodeTextBox_TextChanged;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(680, 279);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(125, 27);
            QuantityTextBox.TabIndex = 18;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(253, 279);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(272, 27);
            DescriptionTextBox.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 312);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(971, 272);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(508, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(494, 185);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // GridDescriptionLabel
            // 
            GridDescriptionLabel.BackColor = SystemColors.ActiveCaption;
            GridDescriptionLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GridDescriptionLabel.ForeColor = SystemColors.ControlLightLight;
            GridDescriptionLabel.Location = new Point(227, 312);
            GridDescriptionLabel.Name = "GridDescriptionLabel";
            GridDescriptionLabel.Size = new Size(298, 41);
            GridDescriptionLabel.TabIndex = 24;
            GridDescriptionLabel.Text = "Descripción";
            GridDescriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GridPriceLabel
            // 
            GridPriceLabel.BackColor = SystemColors.ActiveCaption;
            GridPriceLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GridPriceLabel.ForeColor = SystemColors.ControlLightLight;
            GridPriceLabel.Location = new Point(519, 312);
            GridPriceLabel.Name = "GridPriceLabel";
            GridPriceLabel.Size = new Size(166, 41);
            GridPriceLabel.TabIndex = 25;
            GridPriceLabel.Text = "Precio";
            GridPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GridQuantityLabel
            // 
            GridQuantityLabel.BackColor = SystemColors.ActiveCaption;
            GridQuantityLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GridQuantityLabel.ForeColor = SystemColors.ControlLightLight;
            GridQuantityLabel.Location = new Point(680, 312);
            GridQuantityLabel.Name = "GridQuantityLabel";
            GridQuantityLabel.Size = new Size(137, 41);
            GridQuantityLabel.TabIndex = 26;
            GridQuantityLabel.Text = "Cantidad";
            GridQuantityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(808, 312);
            label2.Name = "label2";
            label2.Size = new Size(194, 41);
            label2.TabIndex = 27;
            label2.Text = "Importe";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPriceLabel.ForeColor = SystemColors.ControlText;
            TotalPriceLabel.Location = new Point(680, 604);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(117, 41);
            TotalPriceLabel.TabIndex = 28;
            TotalPriceLabel.Text = "TOTAL:";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(803, 604);
            label1.Name = "label1";
            label1.Size = new Size(189, 41);
            label1.TabIndex = 29;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ClientLabel
            // 
            ClientLabel.BackColor = SystemColors.ButtonHighlight;
            ClientLabel.BorderStyle = BorderStyle.Fixed3D;
            ClientLabel.Location = new Point(139, 167);
            ClientLabel.Name = "ClientLabel";
            ClientLabel.Size = new Size(174, 25);
            ClientLabel.TabIndex = 31;
            // 
            // ClientCodeTextBox
            // 
            ClientCodeTextBox.Location = new Point(139, 129);
            ClientCodeTextBox.Name = "ClientCodeTextBox";
            ClientCodeTextBox.Size = new Size(174, 27);
            ClientCodeTextBox.TabIndex = 32;
            ClientCodeTextBox.TextChanged += ClientCodeTextBox_TextChanged;
            // 
            // Facturacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 700);
            Controls.Add(ClientCodeTextBox);
            Controls.Add(ClientLabel);
            Controls.Add(label1);
            Controls.Add(TotalPriceLabel);
            Controls.Add(label2);
            Controls.Add(GridQuantityLabel);
            Controls.Add(GridPriceLabel);
            Controls.Add(GridDescriptionLabel);
            Controls.Add(GridCodeLabel);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
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
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(GridCodeLabel, 0);
            Controls.SetChildIndex(GridDescriptionLabel, 0);
            Controls.SetChildIndex(GridPriceLabel, 0);
            Controls.SetChildIndex(GridQuantityLabel, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(TotalPriceLabel, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(ClientLabel, 0);
            Controls.SetChildIndex(ClientCodeTextBox, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label GridCodeLabel;
        private Label TextLabel2;
        private Label SellerLabel;
        private Label TextLabel3;
        private TextBox PriceTextBox;
        private TextBox ProductCodeTextBox;
        private TextBox QuantityTextBox;
        private TextBox DescriptionTextBox;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label GridDescriptionLabel;
        private Label GridPriceLabel;
        private Label GridQuantityLabel;
        private Label label2;
        private Label TotalPriceLabel;
        private Label label1;
        private Label ClientLabel;
        private TextBox ClientCodeTextBox;
    }
}