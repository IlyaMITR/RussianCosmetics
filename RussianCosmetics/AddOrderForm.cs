using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace RussianCosmetics
{
    public partial class AddOrderForm : Form
    {
        DataGridView table;
        List<Order> orders;
        List<Usluga> uslugi;
        List<Client> clients;
        Validation validation = new Validation();
        public AddOrderForm(DataGridView ordersTable, List<Order> ordersList, List<Usluga> uslugiList, List<Client> clientsList)
        {
            InitializeComponent();
            table = ordersTable;
            orders = ordersList;
            uslugi = uslugiList;
            clients = clientsList;
        }

        private void OrderCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                string client = validation.Do(OrderClientNameComboBox, OrderClientNameLabel);
                string uslugiString = validation.Do(OrderUslugaListBox, OrderUslugaLabel);
                string[] uslugiNames = uslugiString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                List<Usluga> matchingUslugi = uslugi.Where(p => uslugiNames.Contains(p.name)).ToList();
                Order order = new Order(client, matchingUslugi);
                orders.Add(order);
                table.Rows.Add(order.num, order.uslugi, order.client, order.price.ToString(), order.date);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            foreach (Client client in clients)
            {
                if (client is FizLitso fiz)
                {
                    OrderClientNameComboBox.Items.Add(fiz.fio);
                }
                else if (client is YurLitso yur)
                {
                    OrderClientNameComboBox.Items.Add(yur.name);
                }
            }
            foreach (Usluga usluga in uslugi)
            {
                OrderUslugaListBox.Items.Add(usluga.name);
            }
        }
    }

    public class Order
    {
        public string num;
        public string uslugi;
        public string client;
        public int price;
        public string date;
        public Order(string client, List<Usluga> uslugi) 
        {
            num = new DateTime().Ticks.ToString();
            this.client = client;
            this.uslugi = string.Join(",", uslugi.Select(u => u.name));
            foreach (Usluga usluga in uslugi)
            {
                decimal price;
                if (decimal.TryParse(usluga.price, out price))
                {
                    this.price += (int)price;
                }
            }
            date = DateTime.Now.ToString();
        }
    }

}
