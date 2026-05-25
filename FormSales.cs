using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RestauraceKasa.Models;

namespace RestauraceKasa
{
    public partial class FormSales : Form
    {

        private List<Product> _products;
        private List<RestaurantTable> _tables;
        private List<string> _categories;

        private Size btnTableSize = new Size(120, 60);
        private Padding btnTableMargin = new Padding(28, 10, 0, 10);

        private Size btnCategorySize = new Size(80, 60);
        private Padding btnCategoryMargin = new Padding(10);

        private Size btnProductSize = new Size(90, 80);
        private Padding btnProductMargin = new Padding(10);


        //proměná pro předávání čísla stolu aktuálně otevřeného účtu
        private RestaurantTable CurrentlyOpenTable = new RestaurantTable();


        public FormSales(List<Product> products, List<RestaurantTable> tables, List<string> categories)
        {
            InitializeComponent();


            dgvOrder.Columns.Add("nameColumn", "Název");
            dgvOrder.Columns.Add("priceColumn", "Cena");
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.MultiSelect = false;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.ReadOnly = true;
            dgvOrder.AllowUserToResizeColumns = false;
            dgvOrder.AllowUserToResizeRows = false;
            dgvOrder.RowTemplate.Height = 28;

            if (dgvOrder.Columns["nameColumn"] is DataGridViewColumn nameCol)
            {
                nameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                nameCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            if (dgvOrder.Columns["priceColumn"] is DataGridViewColumn priceCol)
            {
                priceCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                priceCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            this._products = products;
            this._tables = tables;
            this._categories = categories;

            GenerateTableButtons();
            GenerateCategoryButtnos();

        }


        private void GenerateTableButtons()
        {
            panelTables.Controls.Clear();

            foreach (RestaurantTable table in _tables)
            {
                Button btnTable = new Button();

                btnTable.Text = table.TableNumber.ToString();
                btnTable.Size = btnTableSize;
                btnTable.Margin = btnTableMargin;
                btnTable.Font = new Font(btnTable.Font.FontFamily, 18, FontStyle.Bold);
                btnTable.BackColor = table.IsOccupied ? Color.Salmon : Color.LightGreen;
                btnTable.FlatAppearance.BorderColor = Color.Orange;
                btnTable.FlatStyle = FlatStyle.Flat;
                btnTable.FlatAppearance.BorderSize = 0;

                btnTable.Click += (sender, e) =>
                {

                    if (sender is Button clickedButton)
                    {
                        HighlightSelectedTableButton(clickedButton);
                    }

                    OpenTableOrder(table);
                };

                panelTables.Controls.Add(btnTable);
            }

        }

        private void GenerateCategoryButtnos()
        {
            panelCategories.Controls.Clear();

            foreach (string category in _categories)
            {
                Button btnCategory = new Button();

                btnCategory.Text = category;
                btnCategory.Size = btnCategorySize;
                btnCategory.Margin = btnCategoryMargin;
                btnCategory.Font = new Font(btnCategory.Font.FontFamily, 12);
                btnCategory.BackColor = Color.White;
                btnCategory.FlatAppearance.BorderSize = 0;

                btnCategory.Click += (sender, e) =>
                {
                    GenerateProductButtons(category);
                };


                panelCategories.Controls.Add(btnCategory);

            }

        }

        private void GenerateProductButtons(string category)
        {
            panelProducts.Controls.Clear();

            foreach (Product product in _products)
            {
                if (product.Category.Equals(category))
                {
                    Button btnProduct = new Button();

                    btnProduct.Text = product.Name;
                    btnProduct.Size = btnProductSize;
                    btnProduct.Margin = btnProductMargin;
                    btnProduct.Font = new Font(btnProduct.Font.FontFamily, 12);
                    btnProduct.BackColor = Color.White;
                    btnProduct.FlatAppearance.BorderSize = 0;


                    btnProduct.Click += (sender, e) =>
                    {
                        AddProductToOrder(product);
                    };


                    panelProducts.Controls.Add(btnProduct);
                }
            }
        }

        private void HighlightSelectedTableButton(Button selectedButton)
        {
            foreach (Control control in panelTables.Controls)
            {
                if (control is Button btn)
                {
                    btn.FlatAppearance.BorderSize = 0;
                   
                }
            }
            selectedButton.FlatAppearance.BorderSize = 4;
            
        }


        private void OpenTableOrder(RestaurantTable table)
        {
            dgvOrder.SuspendLayout();

            dgvOrder.Rows.Clear();

            foreach (Product product in table.CurrentOrder.Items)
            {
                dgvOrder.Rows.Add(product.Name, product.Price);
            }

            CurrentlyOpenTable = table;
            
            dgvOrder.ResumeLayout();

        }


        private void AddProductToOrder(Product product)
        {
            dgvOrder.Rows.Add(product.Name, product.Price);
        }

        private void BtnSaveOrder_Click(object sender, EventArgs e)
        {

            CurrentlyOpenTable.CurrentOrder.Items.Clear();

            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["nameColumn"].Value == null) continue;

                if (row.Cells["nameColumn"].Value != null)
                {

                    string name = Convert.ToString(row.Cells["nameColumn"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["priceColumn"].Value);

                    Product newProduct = new Product { Name = name, Price = price };
                    CurrentlyOpenTable.CurrentOrder.Items.Add(newProduct);


                }
            }



            //TODO: označí stůl jako obsazený

            //TODO: aktualizuje zobrazení tlačítek stolů, aby se změnila barva obsazených stolů

            //TODO: přidat logiku pro zobrazení celkové ceny objednávky

            //TODO: přidat logiku pro zobrazení možnosti platby a dokončení objednávky

            //TODO: přidat logiku pro zobrazení možnosti zobrazení historie objednávek pro každý stůl -> bude v administraci(form)
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            //TODO: přidat logiku pro odstranění vybraného produktu z objednávky (odstraní řádek z dgvOrder a aktualizuje celkovou cenu)
        }
    }
}
