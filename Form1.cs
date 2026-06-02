using RestauraceKasa.Models;

namespace RestauraceKasa
{
    public partial class Form1 : Form
    {

        private List<Product> _products = new List<Product>();
        private List<RestaurantTable> _tables = new List<RestaurantTable>();
        private List<string> _categories = new List<string>();
        private List<Order> _orders = new List<Order>();
        private List<ArchivedOrder> _archivedOrders = new List<ArchivedOrder>();

        public Form1()
        {
            InitializeComponent();

            _products = DataManager.LoadData<Product>("products.json");
            _tables = DataManager.LoadData<RestaurantTable>("tables.json");
            _categories = DataManager.LoadData<string>("categories.json");
            _orders = DataManager.LoadData<Order>("orders.json");
            _archivedOrders = DataManager.LoadData<ArchivedOrder>("archivedOrders.json");

        }


        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin adminWindow = new FormAdmin(_products, _tables, _categories, _archivedOrders);
            adminWindow.ShowDialog();

            DataManager.SaveData(_products, "products.json");
            DataManager.SaveData(_tables, "tables.json");
            DataManager.SaveData(_categories, "categories.json");
            DataManager.SaveData(_orders, "orders.json");
            DataManager.SaveData(_archivedOrders, "archivedOrders.json");

        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            FormSales salesWindow = new FormSales(_products, _tables, _categories, _archivedOrders);
            salesWindow.ShowDialog();

            DataManager.SaveData(_orders, "orders.json");
            DataManager.SaveData(_archivedOrders, "archivedOrders.json");
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataManager.SaveData(_products, "products.json");
            DataManager.SaveData(_tables, "tables.json");
            DataManager.SaveData(_categories, "categories.json");
            DataManager.SaveData(_orders, "orders.json");
        }



    }
}
