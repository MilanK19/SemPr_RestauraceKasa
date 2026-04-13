namespace RestauraceKasa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSales = new Button();
            btnAdmin = new Button();
            SuspendLayout();
            // 
            // btnSales
            // 
            btnSales.Location = new Point(298, 111);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(184, 63);
            btnSales.TabIndex = 0;
            btnSales.Text = "Obsluha";
            btnSales.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(298, 197);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(184, 63);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Editace";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdmin);
            Controls.Add(btnSales);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSales;
        private Button btnAdmin;
    }
}
