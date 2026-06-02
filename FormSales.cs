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
        private List<ArchivedOrder> _archivedOrders;

        private Size btnTableSize = new Size(120, 60);
        private Padding btnTableMargin = new Padding(28, 10, 0, 10);

        private Size btnCategorySize = new Size(80, 60);
        private Padding btnCategoryMargin = new Padding(10);

        private Size btnProductSize = new Size(90, 80);
        private Padding btnProductMargin = new Padding(10);


        //proměná pro předávání čísla stolu aktuálně otevřeného účtu
        private RestaurantTable CurrentlyOpenTable = new RestaurantTable();


        public FormSales(List<Product> products, List<RestaurantTable> tables, List<string> categories, List<ArchivedOrder> archivedOrders)
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
            this._archivedOrders = archivedOrders;

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
                int rowIndex = dgvOrder.Rows.Add(product.Name, product.Price);
                dgvOrder.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGray;

            }

            CurrentlyOpenTable = table;

            txtTotalPrice.Text = Convert.ToString(table.CurrentOrder.TotalPrice);

            dgvOrder.ResumeLayout();

        }


        private void AddProductToOrder(Product product)
        {
            dgvOrder.Rows.Add(product.Name, product.Price);
        }


        private void BtnSaveOrder_Click(object sender, EventArgs e)
        {

            List<Product> approvedItems = new List<Product>();

            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["nameColumn"].Value == null) continue;

                string name = Convert.ToString(row.Cells["nameColumn"].Value);
                decimal price = Convert.ToDecimal(row.Cells["priceColumn"].Value);

                if (row.Tag is string tag && tag == "toDelete")
                {
                    // TODO: Zde v budoucnu zavoláte tiskárnu: TiskniStornoLístek(name);

                    // V paměti (CurrentlyOpenTable) tento produkt nechceme, takže ho ignorujeme
                    continue;
                }

                // Pokud řádek smazaný nebyl, uložíme ho do schválených
                Product product = new Product { Name = name, Price = price };
                approvedItems.Add(product);


                // TODO: Zde v budoucnu zavoláte tiskárnu: TiskniDoKuchyneLístek(name);
            }

            CurrentlyOpenTable.CurrentOrder.Items = approvedItems;

            OpenTableOrder(CurrentlyOpenTable);

            foreach (Control control in panelTables.Controls)
            {
                // Najdeme tlačítko, které patří aktuálně uloženému stolu
                if (control is Button btn && btn.Text == CurrentlyOpenTable.TableNumber.ToString())
                {
                    btn.BackColor = CurrentlyOpenTable.IsOccupied ? Color.Salmon : Color.LightGreen;
                    break;
                }
            }


        }





        private void BtnDeleteSelected_Click(object sender, EventArgs e)
        {

            if (dgvOrder.CurrentRow != null)
            {
                DataGridViewRow row = dgvOrder.CurrentRow;

                if (row.DefaultCellStyle.BackColor == Color.LightGray)
                {
                    row.DefaultCellStyle.Font = new Font(dgvOrder.Font, FontStyle.Strikeout);
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    row.DefaultCellStyle.SelectionForeColor = Color.DarkRed;
                    row.DefaultCellStyle.BackColor = Color.LightPink;

                    row.Tag = "toDelete";
                }
                else
                {
                    dgvOrder.Rows.Remove(row);
                }


            }
            else
            {
                MessageBox.Show("Vyberte v tabulce řádek, který chcete smazat.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            if (CurrentlyOpenTable == null || CurrentlyOpenTable.CurrentOrder.Items.Count == 0)
            {
                return;
            }

            decimal total = CurrentlyOpenTable.CurrentOrder.TotalPrice;

           using (FormPaymentDialog paymentForm = new FormPaymentDialog(total))
            {
                DialogResult result = paymentForm.ShowDialog();

                string paymentMethod = string.Empty;

                if (result == DialogResult.Yes)
                {
                    paymentMethod = "Hotove";
                }
                else if (result == DialogResult.No)
                {
                    paymentMethod = "Kartou";
                }
                else
                {
                    return;
                }

                Payment(paymentMethod, total);
            }



        }


        private void Payment(string paymentMethod, decimal total)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"ÚČTENKA - STŮL ČÍSLO: {CurrentlyOpenTable.TableNumber}");
            Console.WriteLine($"Datum: {DateTime.Now}");
            Console.WriteLine("----------------------------------------");
            foreach (Product p in CurrentlyOpenTable.CurrentOrder.Items)
            {
                Console.WriteLine($"{p.Name, -30} {p.Price, 0} Kč");
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"CELKEM: {total} Kč");
            Console.WriteLine($"Placeno: {paymentMethod}");
            Console.WriteLine("========================================");


            ArchivedOrder archivedOrder = new ArchivedOrder
            {
                TableNumber = CurrentlyOpenTable.TableNumber,
                PaymentTime = DateTime.Now,
                PaymentMethod = paymentMethod,
                TotalPrice = total,
                Items = new List<Product>(CurrentlyOpenTable.CurrentOrder.Items)
            };
            _archivedOrders.Add(archivedOrder);

            CurrentlyOpenTable.CurrentOrder.Items.Clear();

            OpenTableOrder(CurrentlyOpenTable);

            foreach (Control control in panelTables.Controls)
            {
                if (control is Button btn && btn.Text == CurrentlyOpenTable.TableNumber.ToString())
                {
                    btn.BackColor = Color.LightGreen;
                    btn.FlatAppearance.BorderSize = 0;
                    break;
                }
            }


        }








        
    }
}
