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
            components = new System.ComponentModel.Container();
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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            tabTables = new TabPage();
            panel2 = new Panel();
            btnUpdateTable = new Button();
            btnAddTable = new Button();
            btnDeleteTable = new Button();
            label1 = new Label();
            numTableNumber = new NumericUpDown();
            dgvTables = new DataGridView();
            tableNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            currentOrderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isOccupiedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            restaurantTableBindingSource = new BindingSource(components);
            tabCategory = new TabPage();
            lbCategories = new ListBox();
            panel3 = new Panel();
            btnUpdateCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            labelEditCategory = new Label();
            txtCategory = new TextBox();
            tabPaymentHistory = new TabPage();
            dgvArcivedOrderProducts = new DataGridView();
            dgvArchivedOrders = new DataGridView();
            tableNumberDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            paymentTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentMethodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            archivedOrderBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numProductPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            tabTables.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTableNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTables).BeginInit();
            ((System.ComponentModel.ISupportInitialize)restaurantTableBindingSource).BeginInit();
            tabCategory.SuspendLayout();
            panel3.SuspendLayout();
            tabPaymentHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArcivedOrderProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArchivedOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)archivedOrderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMenu);
            tabControl1.Controls.Add(tabTables);
            tabControl1.Controls.Add(tabCategory);
            tabControl1.Controls.Add(tabPaymentHistory);
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
            btnUpdateProduct.Text = "Uložit změny Produktu";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += BtnUpdateProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(163, 224);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(99, 43);
            btnDeleteProduct.TabIndex = 5;
            btnDeleteProduct.Text = "Smazat vybraný produkt";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += BtnDeleteProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(36, 158);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(99, 43);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Přidat do menu";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += BtnAddProduct_Click;
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
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dgvProducts.DataSource = productBindingSource;
            dgvProducts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProducts.Location = new Point(6, 6);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(440, 386);
            dgvProducts.TabIndex = 0;
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Název";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Kategorie";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Cena";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
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
            panel2.Location = new Point(267, 9);
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
            btnUpdateTable.Text = "Uložit změny stolu";
            btnUpdateTable.UseVisualStyleBackColor = true;
            btnUpdateTable.Click += BtnUpdateTable_Click;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(26, 74);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(106, 43);
            btnAddTable.TabIndex = 3;
            btnAddTable.Text = "Přidat stůl";
            btnAddTable.UseVisualStyleBackColor = true;
            btnAddTable.Click += BtnAddTable_Click;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(150, 137);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(108, 43);
            btnDeleteTable.TabIndex = 4;
            btnDeleteTable.Text = "Smazat vybraný stůl";
            btnDeleteTable.UseVisualStyleBackColor = true;
            btnDeleteTable.Click += BtnDeleteTable_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 27);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Číslo stolu:";
            // 
            // numTableNumber
            // 
            numTableNumber.Location = new Point(113, 25);
            numTableNumber.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numTableNumber.Name = "numTableNumber";
            numTableNumber.Size = new Size(51, 23);
            numTableNumber.TabIndex = 2;
            // 
            // dgvTables
            // 
            dgvTables.AllowUserToAddRows = false;
            dgvTables.AllowUserToDeleteRows = false;
            dgvTables.AutoGenerateColumns = false;
            dgvTables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTables.Columns.AddRange(new DataGridViewColumn[] { tableNumberDataGridViewTextBoxColumn, currentOrderDataGridViewTextBoxColumn, isOccupiedDataGridViewCheckBoxColumn });
            dgvTables.DataSource = restaurantTableBindingSource;
            dgvTables.Location = new Point(6, 6);
            dgvTables.MultiSelect = false;
            dgvTables.Name = "dgvTables";
            dgvTables.ReadOnly = true;
            dgvTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTables.Size = new Size(255, 386);
            dgvTables.TabIndex = 0;
            dgvTables.SelectionChanged += DgvTables_SelectionChanged;
            // 
            // tableNumberDataGridViewTextBoxColumn
            // 
            tableNumberDataGridViewTextBoxColumn.DataPropertyName = "TableNumber";
            tableNumberDataGridViewTextBoxColumn.HeaderText = "Číslo stolu";
            tableNumberDataGridViewTextBoxColumn.Name = "tableNumberDataGridViewTextBoxColumn";
            tableNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentOrderDataGridViewTextBoxColumn
            // 
            currentOrderDataGridViewTextBoxColumn.DataPropertyName = "CurrentOrder";
            currentOrderDataGridViewTextBoxColumn.HeaderText = "CurrentOrder";
            currentOrderDataGridViewTextBoxColumn.Name = "currentOrderDataGridViewTextBoxColumn";
            currentOrderDataGridViewTextBoxColumn.ReadOnly = true;
            currentOrderDataGridViewTextBoxColumn.Visible = false;
            // 
            // isOccupiedDataGridViewCheckBoxColumn
            // 
            isOccupiedDataGridViewCheckBoxColumn.DataPropertyName = "IsOccupied";
            isOccupiedDataGridViewCheckBoxColumn.HeaderText = "IsOccupied";
            isOccupiedDataGridViewCheckBoxColumn.Name = "isOccupiedDataGridViewCheckBoxColumn";
            isOccupiedDataGridViewCheckBoxColumn.ReadOnly = true;
            isOccupiedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // restaurantTableBindingSource
            // 
            restaurantTableBindingSource.DataSource = typeof(Models.RestaurantTable);
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
            lbCategories.SelectedIndexChanged += LbCategories_SelectionChanged;
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
            btnUpdateCategory.Text = "Uložit změny kategorie";
            btnUpdateCategory.UseVisualStyleBackColor = true;
            btnUpdateCategory.Click += BtnUpdateCategory_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(151, 153);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(111, 38);
            btnDeleteCategory.TabIndex = 3;
            btnDeleteCategory.Text = "Smazat vybranou kategorii";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += BtnDeleteCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(19, 92);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(108, 39);
            btnAddCategory.TabIndex = 2;
            btnAddCategory.Text = "Přidat Kategorii";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += BtnAddCategory_Click;
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
            // tabPaymentHistory
            // 
            tabPaymentHistory.Controls.Add(dgvArcivedOrderProducts);
            tabPaymentHistory.Controls.Add(dgvArchivedOrders);
            tabPaymentHistory.Location = new Point(4, 24);
            tabPaymentHistory.Name = "tabPaymentHistory";
            tabPaymentHistory.Padding = new Padding(3);
            tabPaymentHistory.Size = new Size(768, 398);
            tabPaymentHistory.TabIndex = 3;
            tabPaymentHistory.Text = "Historie plateb";
            tabPaymentHistory.UseVisualStyleBackColor = true;
            // 
            // dgvArcivedOrderProducts
            // 
            dgvArcivedOrderProducts.AllowUserToAddRows = false;
            dgvArcivedOrderProducts.AllowUserToDeleteRows = false;
            dgvArcivedOrderProducts.AllowUserToOrderColumns = true;
            dgvArcivedOrderProducts.AutoGenerateColumns = false;
            dgvArcivedOrderProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArcivedOrderProducts.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, categoryDataGridViewTextBoxColumn1, priceDataGridViewTextBoxColumn1 });
            dgvArcivedOrderProducts.DataSource = productBindingSource;
            dgvArcivedOrderProducts.Location = new Point(457, 6);
            dgvArcivedOrderProducts.Name = "dgvArcivedOrderProducts";
            dgvArcivedOrderProducts.ReadOnly = true;
            dgvArcivedOrderProducts.Size = new Size(305, 386);
            dgvArcivedOrderProducts.TabIndex = 1;
            // 
            // dgvArchivedOrders
            // 
            dgvArchivedOrders.AllowUserToAddRows = false;
            dgvArchivedOrders.AllowUserToDeleteRows = false;
            dgvArchivedOrders.AllowUserToOrderColumns = true;
            dgvArchivedOrders.AutoGenerateColumns = false;
            dgvArchivedOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchivedOrders.Columns.AddRange(new DataGridViewColumn[] { tableNumberDataGridViewTextBoxColumn1, paymentTimeDataGridViewTextBoxColumn, paymentMethodDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn });
            dgvArchivedOrders.DataSource = archivedOrderBindingSource;
            dgvArchivedOrders.Location = new Point(6, 6);
            dgvArchivedOrders.Name = "dgvArchivedOrders";
            dgvArchivedOrders.ReadOnly = true;
            dgvArchivedOrders.Size = new Size(445, 386);
            dgvArchivedOrders.TabIndex = 0;
            dgvArchivedOrders.SelectionChanged += DgvArchivedOrders_SelectionChanged;
            // 
            // tableNumberDataGridViewTextBoxColumn1
            // 
            tableNumberDataGridViewTextBoxColumn1.DataPropertyName = "TableNumber";
            tableNumberDataGridViewTextBoxColumn1.HeaderText = "TableNumber";
            tableNumberDataGridViewTextBoxColumn1.Name = "tableNumberDataGridViewTextBoxColumn1";
            tableNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // paymentTimeDataGridViewTextBoxColumn
            // 
            paymentTimeDataGridViewTextBoxColumn.DataPropertyName = "PaymentTime";
            paymentTimeDataGridViewTextBoxColumn.HeaderText = "PaymentTime";
            paymentTimeDataGridViewTextBoxColumn.Name = "paymentTimeDataGridViewTextBoxColumn";
            paymentTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            paymentMethodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // archivedOrderBindingSource
            // 
            archivedOrderBindingSource.DataSource = typeof(Models.ArchivedOrder);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn1
            // 
            categoryDataGridViewTextBoxColumn1.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn1.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn1.Name = "categoryDataGridViewTextBoxColumn1";
            categoryDataGridViewTextBoxColumn1.ReadOnly = true;
            categoryDataGridViewTextBoxColumn1.Visible = false;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormAdmin";
            Text = "Administrace";
            tabControl1.ResumeLayout(false);
            tabMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numProductPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            tabTables.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTableNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTables).EndInit();
            ((System.ComponentModel.ISupportInitialize)restaurantTableBindingSource).EndInit();
            tabCategory.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPaymentHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvArcivedOrderProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArchivedOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)archivedOrderBindingSource).EndInit();
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
        private NumericUpDown numTableNumber;
        private DataGridViewTextBoxColumn tableNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentOrderDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isOccupiedDataGridViewCheckBoxColumn;
        private BindingSource restaurantTableBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private TabPage tabPaymentHistory;
        private DataGridView dgvArchivedOrders;
        private DataGridViewTextBoxColumn tableNumberDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn paymentTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private BindingSource archivedOrderBindingSource;
        private DataGridView dgvArcivedOrderProducts;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
    }
}