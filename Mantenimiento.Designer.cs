namespace EcoPoS_System
{
    partial class Mantenimiento
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
            RequestButton = new Button();
            SaveButton = new Button();
            NewButton = new Button();
            DeleteButton = new Button();
            SuspendLayout();
            // 
            // RequestButton
            // 
            RequestButton.Location = new Point(89, 252);
            RequestButton.Name = "RequestButton";
            RequestButton.Size = new Size(94, 29);
            RequestButton.TabIndex = 0;
            RequestButton.Text = "Consultar";
            RequestButton.UseVisualStyleBackColor = true;
            RequestButton.Click += this.RequestButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(375, 252);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Guardar";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // NewButton
            // 
            NewButton.Location = new Point(221, 252);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(94, 29);
            NewButton.TabIndex = 2;
            NewButton.Text = "Nuevo";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += this.NewButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(519, 252);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Eliminar";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += this.DeleteButton_Click;
            // 
            // Mantenimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 323);
            Controls.Add(DeleteButton);
            Controls.Add(NewButton);
            Controls.Add(SaveButton);
            Controls.Add(RequestButton);
            Name = "Mantenimiento";
            Text = "Mantenimiento";
            Load += Mantenimiento_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button RequestButton;
        private Button SaveButton;
        private Button NewButton;
        private Button DeleteButton;
    }
}