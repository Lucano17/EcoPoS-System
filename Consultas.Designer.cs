namespace EcoPoS_System
{
    partial class Consultas
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
            SelectButton = new Button();
            PrintButton = new Button();
            NameLabel = new Label();
            SearchButton = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(498, 349);
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(153, 349);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(94, 29);
            SelectButton.TabIndex = 0;
            SelectButton.Text = "Seleccionar";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Click += SelectButton_Click_1;
            // 
            // PrintButton
            // 
            PrintButton.Location = new Point(322, 349);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(94, 29);
            PrintButton.TabIndex = 1;
            PrintButton.Text = "Imprimir";
            PrintButton.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(120, 31);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(67, 20);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Nombre:";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(528, 26);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 31);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "Buscar";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 27);
            textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(97, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(543, 267);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Consultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 390);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(SearchButton);
            Controls.Add(NameLabel);
            Controls.Add(PrintButton);
            Controls.Add(SelectButton);
            Name = "Consultas";
            Text = "Consultas";
            Load += Consultas_Load_1;
            Controls.SetChildIndex(SelectButton, 0);
            Controls.SetChildIndex(PrintButton, 0);
            Controls.SetChildIndex(NameLabel, 0);
            Controls.SetChildIndex(SearchButton, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(ExitButton, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label NameLabel;
        public DataGridView dataGridView1;
        public Button SelectButton;
        public Button PrintButton;
        public Button SearchButton;
        public TextBox textBox1;
    }
}