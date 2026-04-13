namespace RestauraceKasa
{
    partial class FormAdmin
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
            tabControl1 = new TabControl();
            tabMenu = new TabPage();
            panel1 = new Panel();
            cmbCategory = new ComboBox();
            labelCategory = new Label();
            btnUpdateProduct = new Button();
            btnDeleteProduct = new Button();
            btnAddProduct = new Button();
            numProductPrice = new NumericUpDown();
            labelPrice = new Label();
            labelName = new Label();
            txtProductName = new TextBox();
            dgvProducts = new DataGridView();
            tabTables = new TabPage();
            panel2 = new Panel();
            btnUpdateTable = new Button();
            btnAddTable = new Button();
            btnDeleteTable = new Button();
            label1 = new Label();
            numTableNumber = new NumericUpDown();
            dgvTables = new DataGridView();
            tabCategory = new TabPage();
            lbCategories = new ListBox();
            panel3 = new Panel();
            btnUpdateCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            labelEditCategory = new Label();
            txtCategory = new TextBox();
            tabControl1.SuspendLayout();
            tabMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numProductPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            tabTables.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTableNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTables).BeginInit();
            tabCategory.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMenu);
            tabControl1.Controls.Add(tabTables);
            tabControl1.Controls.Add(tabCategory);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabMenu
            // 
            tabMenu.Controls.Add(panel1);
            tabMenu.Controls.Add(dgvProducts);
            tabMenu.Location = new Point(4, 24);
            tabMenu.Name = "tabMenu";
            tabMenu.Padding = new Padding(3);
            tabMenu.Size = new Size(768, 398);
            tabMenu.TabIndex = 0;
            tabMenu.Text = "Správa menu";
            tabMenu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbCategory);
            panel1.Controls.Add(labelCategory);
            panel1.Controls.Add(btnUpdateProduct);
            panel1.Controls.Add(btnDeleteProduct);
            panel1.Controls.Add(btnAddProduct);
            panel1.Controls.Add(numProductPrice);
            panel1.Controls.Add(labelPrice);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(txtProductName);
            panel1.Location = new Point(452, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 386);
            panel1.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(141, 65);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 8;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(57, 65);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(60, 15);
            labelCategory.TabIndex = 7;
            labelCategory.Text = "Kategorie ";
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(36, 224);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(99, 43);
            btnUpdateProduct.TabIndex = 6;
            btnUpdateProduct.Text = "Uložit Změny";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(163, 224);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(99, 43);
            btnDeleteProduct.TabIndex = 5;
            btnDeleteProduct.Text = "Smazat vybrané";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(36, 158);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(99, 43);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Přidat do menu";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // numProductPrice
            // 
            numProductPrice.Location = new Point(141, 109);
            numProductPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numProductPrice.Name = "numProductPrice";
            numProductPrice.Size = new Size(120, 23);
            numProductPrice.TabIndex = 3;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(57, 111);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(37, 15);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Cena:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(57, 29);
            labelName.Name = "labelName";
            labelName.Size = new Size(45, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Název: ";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(122, 26);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(140, 23);
            txtProductName.TabIndex = 0;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(6, 6);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(440, 386);
            dgvProducts.TabIndex = 0;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // tabTables
            // 
            tabTables.Controls.Add(panel2);
            tabTables.Controls.Add(dgvTables);
            tabTables.Location = new Point(4, 24);
            tabTables.Name = "tabTables";
            tabTables.Padding = new Padding(3);
            tabTables.Size = new Size(768, 398);
            tabTables.TabIndex = 1;
            tabTables.Text = "Správa stolů";
            tabTables.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnUpdateTable);
            panel2.Controls.Add(btnAddTable);
            panel2.Controls.Add(btnDeleteTable);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(numTableNumber);
            panel2.Location = new Point(376, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 386);
            panel2.TabIndex = 5;
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.Location = new Point(26, 137);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.Size = new Size(106, 43);
            btnUpdateTable.TabIndex = 5;
            btnUpdateTable.Text = "Uložit změny";
            btnUpdateTable.UseVisualStyleBackColor = true;
            btnUpdateTable.Click += btnUpdateProduct_Click;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(26, 74);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(106, 43);
            btnAddTable.TabIndex = 3;
            btnAddTable.Text = "Přidat stůl";
            btnAddTable.UseVisualStyleBackColor = true;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(150, 137);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(108, 43);
            btnDeleteTable.TabIndex = 4;
            btnDeleteTable.Text = "Smazat stůl";
            btnDeleteTable.UseVisualStyleBackColor = true;
            btnDeleteTable.Click += btnDeleteTable_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 27);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Číslo stolu";
            // 
            // numTableNumber
            // 
            numTableNumber.Location = new Point(114, 25);
            numTableNumber.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numTableNumber.Name = "numTableNumber";
            numTableNumber.Size = new Size(51, 23);
            numTableNumber.TabIndex = 2;
            // 
            // dgvTables
            // 
            dgvTables.AllowUserToAddRows = false;
            dgvTables.AllowUserToDeleteRows = false;
            dgvTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTables.Location = new Point(6, 6);
            dgvTables.MultiSelect = false;
            dgvTables.Name = "dgvTables";
            dgvTables.ReadOnly = true;
            dgvTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTables.Size = new Size(364, 386);
            dgvTables.TabIndex = 0;
            dgvTables.SelectionChanged += dgvTables_SelectionChanged;
            // 
            // tabCategory
            // 
            tabCategory.Controls.Add(lbCategories);
            tabCategory.Controls.Add(panel3);
            tabCategory.Location = new Point(4, 24);
            tabCategory.Name = "tabCategory";
            tabCategory.Padding = new Padding(3);
            tabCategory.Size = new Size(768, 398);
            tabCategory.TabIndex = 2;
            tabCategory.Text = "Správa Kategorie";
            tabCategory.UseVisualStyleBackColor = true;
            // 
            // lbCategories
            // 
            lbCategories.FormattingEnabled = true;
            lbCategories.Location = new Point(6, 6);
            lbCategories.Name = "lbCategories";
            lbCategories.Size = new Size(249, 379);
            lbCategories.TabIndex = 2;
            lbCategories.SelectedIndexChanged += lbCategories_SelectionChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnUpdateCategory);
            panel3.Controls.Add(btnDeleteCategory);
            panel3.Controls.Add(btnAddCategory);
            panel3.Controls.Add(labelEditCategory);
            panel3.Controls.Add(txtCategory);
            panel3.Location = new Point(261, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(307, 386);
            panel3.TabIndex = 1;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.Location = new Point(19, 153);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(108, 38);
            btnUpdateCategory.TabIndex = 4;
            btnUpdateCategory.Text = "Uložit změny";
            btnUpdateCategory.UseVisualStyleBackColor = true;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(151, 153);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(111, 38);
            btnDeleteCategory.TabIndex = 3;
            btnDeleteCategory.Text = "Smazat kategorii";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(19, 92);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(108, 39);
            btnAddCategory.TabIndex = 2;
            btnAddCategory.Text = "Přidat Kategorii";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // labelEditCategory
            // 
            labelEditCategory.AutoSize = true;
            labelEditCategory.Location = new Point(51, 41);
            labelEditCategory.Name = "labelEditCategory";
            labelEditCategory.Size = new Size(94, 15);
            labelEditCategory.TabIndex = 1;
            labelEditCategory.Text = "Název kategorie:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(151, 41);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(111, 23);
            txtCategory.TabIndex = 0;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormAdmin";
            Text = "FormAdmin";
            tabControl1.ResumeLayout(false);
            tabMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numProductPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            tabTables.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTableNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTables).EndInit();
            tabCategory.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabMenu;
        private TabPage tabTables;
        private DataGridView dgvProducts;
        private Panel panel1;
        private Label labelName;
        private TextBox txtProductName;
        private Label labelPrice;
        private Button btnDeleteProduct;
        private Button btnAddProduct;
        private NumericUpDown numProductPrice;
        private Button btnAddTable;
        private NumericUpDown numTableNumber;
        private Label label1;
        private DataGridView dgvTables;
        private Panel panel2;
        private Button btnDeleteTable;
        private Button btnUpdateProduct;
        private Button btnUpdateTable;
        private Label labelCategory;
        private ComboBox cmbCategory;
        private TabPage tabCategory;
        private Panel panel3;
        private Label labelEditCategory;
        private TextBox txtCategory;
        private Button btnUpdateCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private ListBox lbCategories;
    }
}