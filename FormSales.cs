using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public FormSales(List<Product> products, List<RestaurantTable> tables, List<string> categories)
        {
            InitializeComponent();

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
                btnTable.BackColor = table.IsOccupied ? Color.Salmon: Color.LightGreen;
                btnTable.FlatAppearance.BorderSize = 0;

                btnTable.Click += (sender, e) => {
                    OpenTableOrder(table);
                };

                panelTables.Controls.Add(btnTable);
            }

        }

        private void GenerateCategoryButtnos()
        {
            panelCategories.Controls.Clear();

            foreach(string  category in _categories)
            {
                Button btnCategory = new Button();

                btnCategory.Text = category;
                btnCategory.Size = btnCategorySize;
                btnCategory.Margin = btnCategoryMargin;
                btnCategory.Font = new Font(btnCategory.Font.FontFamily, 12);
                btnCategory.BackColor = Color.White;
                btnCategory.FlatAppearance.BorderSize = 0;

                btnCategory.Click += (sender, e) => {
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
                if(product.Category.Equals(category))
                {
                    Button btnProduct = new Button();

                    btnProduct.Text = product.Name;
                    btnProduct.Size = btnProductSize;
                    btnProduct.Margin = btnProductMargin;
                    btnProduct.Font = new Font(btnProduct.Font.FontFamily, 12);
                    btnProduct.BackColor = Color.White;
                    btnProduct.FlatAppearance.BorderSize = 0;


                    btnProduct.Click += (sender, e) => {
                        AddProductToOrder(product);
                    };


                    panelProducts.Controls.Add(btnProduct);
                }
            }
        }


        private void OpenTableOrder(RestaurantTable table)
        {
            //TODO
        }


        private void AddProductToOrder(Product product)
        {
            //TODO
        }





    }
}
