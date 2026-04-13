using RestauraceKasa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestauraceKasa
{
    public partial class FormAdmin : Form
    {
        private BindingList<Product> _productsBinding;
        private BindingList<RestaurantTable> _tablesBinding;
        private BindingList<string> _categoriesBinding;

        


        public FormAdmin(List<Product> products, List<RestaurantTable> tables, List<string> categories)
        {
            InitializeComponent();

            _productsBinding = new BindingList<Product>(products);
            _tablesBinding = new BindingList<RestaurantTable>(tables);
            _categoriesBinding = new BindingList<string>(categories);

            dgvProducts.DataSource = _productsBinding;
            dgvTables.DataSource = _tablesBinding;
            lbCategories.DataSource = _categoriesBinding;
            cmbCategory.DataSource = _categoriesBinding;
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) || cmbCategory.SelectedIndex == -1) return;

            int maxId = _productsBinding.Count > 0 ? _productsBinding.Max(p => p.Id) : 0;

            var newProduct = new Product()
            {
                Id = maxId + 1,
                Name = txtProductName.Text,
                Category = cmbCategory.SelectedItem.ToString(),
                Price = numProductPrice.Value
            };

            _productsBinding.Add(newProduct);

            txtProductName.Clear();
            numProductPrice.Value = 0;
            cmbCategory.SelectedIndex = -1;

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if(dgvProducts.CurrentRow != null)
            {
                var productToDelete = (Product)dgvProducts.CurrentRow.DataBoundItem;
                _productsBinding.Remove(productToDelete);
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvProducts != null)
            {
                var selectedProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;

                txtProductName.Text = selectedProduct.Name;
                numProductPrice.Value = selectedProduct.Price;
                cmbCategory.SelectedItem = selectedProduct.Category;
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if(dgvProducts.CurrentRow != null)
            {
                var productToUpdate = (Product)dgvProducts.CurrentRow.DataBoundItem;

                productToUpdate.Name = txtProductName.Text;
                productToUpdate.Price = numProductPrice.Value;
                productToUpdate.Category = cmbCategory.Text;

                _productsBinding.ResetBindings();

            }
        }




        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (numTableNumber.Value <= 0) return;

            var newTable = new RestaurantTable()
            {
                TableNumber = (int)numTableNumber.Value,
                isOccupied = false
            };

            _tablesBinding.Add(newTable);

            numTableNumber.Value = 0;

        }

        private void btnDeleteTable_Click(object obj, EventArgs e)
        {
            if (dgvTables.CurrentRow != null)
            {
                var tableToDelete = (RestaurantTable)dgvTables.CurrentRow.DataBoundItem;
                _tablesBinding.Remove(tableToDelete);
            }
        }

        private void dgvTables_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTables != null)
            {
                var selectedTable = (RestaurantTable)dgvTables.CurrentRow.DataBoundItem;

                numTableNumber.Value = selectedTable.TableNumber;
            }
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            if (dgvTables.CurrentRow != null)
            {
                var tableToUpdate = (RestaurantTable)dgvTables.CurrentRow.DataBoundItem;

                tableToUpdate.TableNumber = (int)numTableNumber.Value;

                _tablesBinding.ResetBindings();

            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Název Kategorie nesmí být prázdný!", "Chyba zadávání", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _categoriesBinding.Add(txtCategory.Text);
            txtCategory.Clear();

            _categoriesBinding.ResetBindings();

        }

        private void btnDeleteCategory_Click(object  obj, EventArgs e)
        {
            if (lbCategories.SelectedItem != null)
            {
                var CategoryToDelete = lbCategories.SelectedItem.ToString();
                _categoriesBinding.Remove(CategoryToDelete);

                _categoriesBinding.ResetBindings();
            }
        }

        private void lbCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (lbCategories.SelectedIndex != -1 && lbCategories.SelectedItem != null)
            {
                txtCategory.Text = lbCategories.SelectedItem.ToString();
            }
        }


        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbCategories.SelectedIndex;


            if (selectedIndex != -1 && !string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                _categoriesBinding[selectedIndex] = txtCategory.Text.Trim();

                _categoriesBinding.ResetBindings();

            }
        }

           
    }
}
