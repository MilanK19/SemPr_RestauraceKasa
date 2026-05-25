namespace RestauraceKasa
{
    partial class FormSales
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
            dgvOrder = new DataGridView();
            panelActions = new Panel();
            panelTables = new FlowLayoutPanel();
            lblTables = new Label();
            panelCategories = new FlowLayoutPanel();
            panelProducts = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.BackgroundColor = SystemColors.Info;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.GridColor = SystemColors.Info;
            dgvOrder.Location = new Point(199, 12);
            dgvOrder.MultiSelect = false;
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.Size = new Size(420, 434);
            dgvOrder.TabIndex = 0;
            // 
            // panelActions
            // 
            panelActions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelActions.BackColor = Color.Gainsboro;
            panelActions.Location = new Point(199, 452);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(420, 217);
            panelActions.TabIndex = 1;
            // 
            // panelTables
            // 
            panelTables.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelTables.AutoScroll = true;
            panelTables.BackColor = Color.Gainsboro;
            panelTables.FlowDirection = FlowDirection.TopDown;
            panelTables.Location = new Point(12, 54);
            panelTables.Name = "panelTables";
            panelTables.Size = new Size(181, 615);
            panelTables.TabIndex = 5;
            // 
            // lblTables
            // 
            lblTables.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTables.Location = new Point(12, 12);
            lblTables.Name = "lblTables";
            lblTables.Size = new Size(181, 39);
            lblTables.TabIndex = 6;
            lblTables.Text = "Stoly";
            lblTables.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCategories
            // 
            panelCategories.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCategories.BackColor = Color.Gainsboro;
            panelCategories.Location = new Point(625, 12);
            panelCategories.Name = "panelCategories";
            panelCategories.Size = new Size(627, 172);
            panelCategories.TabIndex = 7;
            // 
            // panelProducts
            // 
            panelProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelProducts.BackColor = Color.Gainsboro;
            panelProducts.Location = new Point(625, 190);
            panelProducts.Name = "panelProducts";
            panelProducts.Size = new Size(627, 479);
            panelProducts.TabIndex = 8;
            // 
            // FormSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelProducts);
            Controls.Add(panelCategories);
            Controls.Add(lblTables);
            Controls.Add(panelTables);
            Controls.Add(panelActions);
            Controls.Add(dgvOrder);
            Name = "FormSales";
            Text = "Obsluha";
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrder;
        private Panel panelActions;
        private FlowLayoutPanel panelTables;
        private Label lblTables;
        private FlowLayoutPanel panelCategories;
        private FlowLayoutPanel panelProducts;
    }
}