using RestauraceKasa.Models;

namespace RestauraceKasa
{
    public partial class Form1 : Form
    {

        private List<Product> _products = new List<Product>();
        private List<RestaurantTable> _tables = new List<RestaurantTable>();
        private List<string> _categories = new List<string>();

        public Form1()
        {
            InitializeComponent();

            _products = DataManager.LoadData<Product>("products.json");
            _tables = DataManager.LoadData<RestaurantTable>("tables.json");
            _categories = DataManager.LoadData<string>("categories.json");

        }


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin adminWindow = new FormAdmin(_products, _tables, _categories);
            adminWindow.ShowDialog();

            DataManager.SaveData(_products, "products.json");
            DataManager.SaveData(_tables, "tables.json");
            DataManager.SaveData(_categories, "categories.json");

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            FormSales salesWindow = new FormSales();
            salesWindow.ShowDialog();
        }

       



    }
}
