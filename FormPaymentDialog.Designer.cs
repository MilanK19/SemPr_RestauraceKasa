namespace RestauraceKasa
{
    partial class FormPaymentDialog
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
            txtTotalPrice = new TextBox();
            btnCash = new Button();
            btnCard = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.BackColor = Color.Khaki;
            txtTotalPrice.BorderStyle = BorderStyle.FixedSingle;
            txtTotalPrice.CausesValidation = false;
            txtTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtTotalPrice.ForeColor = Color.Red;
            txtTotalPrice.Location = new Point(163, 31);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(98, 29);
            txtTotalPrice.TabIndex = 4;
            txtTotalPrice.TabStop = false;
            // 
            // btnCash
            // 
            btnCash.BackColor = Color.SpringGreen;
            btnCash.FlatAppearance.BorderColor = Color.White;
            btnCash.FlatStyle = FlatStyle.Flat;
            btnCash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnCash.Location = new Point(47, 73);
            btnCash.Margin = new Padding(5);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(98, 86);
            btnCash.TabIndex = 5;
            btnCash.Text = "HOTOVĚ";
            btnCash.UseVisualStyleBackColor = false;
            btnCash.Click += BtnCash_Click;
            // 
            // btnCard
            // 
            btnCard.BackColor = Color.DarkTurquoise;
            btnCard.FlatAppearance.BorderColor = Color.White;
            btnCard.FlatStyle = FlatStyle.Flat;
            btnCard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnCard.Location = new Point(289, 73);
            btnCard.Margin = new Padding(5);
            btnCard.Name = "btnCard";
            btnCard.Size = new Size(98, 86);
            btnCard.TabIndex = 6;
            btnCard.Text = "KARTOU";
            btnCard.UseVisualStyleBackColor = false;
            btnCard.Click += BtnCard_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Crimson;
            btnCancel.FlatAppearance.BorderColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnCancel.Location = new Point(163, 171);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 56);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "ZRUŠIT";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // FormPaymentDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 241);
            Controls.Add(btnCancel);
            Controls.Add(btnCard);
            Controls.Add(btnCash);
            Controls.Add(txtTotalPrice);
            Name = "FormPaymentDialog";
            Text = "FormPaymentDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotalPrice;
        private Button btnCash;
        private Button btnCard;
        private Button btnCancel;
    }
}