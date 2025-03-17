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
            // ExitButton
            // 
            ExitButton.Location = new Point(565, 355);
            // 
            // RequestButton
            // 
            RequestButton.Location = new Point(42, 355);
            RequestButton.Name = "RequestButton";
            RequestButton.Size = new Size(94, 29);
            RequestButton.TabIndex = 0;
            RequestButton.Text = "Consultar";
            RequestButton.UseVisualStyleBackColor = true;
            RequestButton.Click += RequestButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(308, 355);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Guardar";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // NewButton
            // 
            NewButton.Location = new Point(177, 355);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(94, 29);
            NewButton.TabIndex = 2;
            NewButton.Text = "Nuevo";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(443, 355);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Eliminar";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // Mantenimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 416);
            Controls.Add(DeleteButton);
            Controls.Add(NewButton);
            Controls.Add(SaveButton);
            Controls.Add(RequestButton);
            Name = "Mantenimiento";
            Text = "Mantenimiento";
            Load += Mantenimiento_Load;
            Controls.SetChildIndex(RequestButton, 0);
            Controls.SetChildIndex(SaveButton, 0);
            Controls.SetChildIndex(NewButton, 0);
            Controls.SetChildIndex(DeleteButton, 0);
            Controls.SetChildIndex(ExitButton, 0);
            ResumeLayout(false);
        }

        #endregion

        public Button RequestButton;
        public Button SaveButton;
        public Button NewButton;
        public Button DeleteButton;
    }
}