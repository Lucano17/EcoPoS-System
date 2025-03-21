namespace EcoPoS_System
{
    partial class Consultar_Ventas
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
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Click += SearchButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(528, 349);
            // 
            // Consultar_Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Consultar_Ventas";
            Text = "Consultar ventas";
            WindowState = FormWindowState.Maximized;
            Load += Consultar_Ventas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}