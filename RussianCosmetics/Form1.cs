using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianCosmetics
{
    public partial class Form1 : Form
    {

        List<Client> clients = new List<Client>();
        List<Usluga> uslugi = new List<Usluga>();
        List<Order> orders = new List<Order>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddUslugaButton_Click(object sender, EventArgs e)
        {
            AddUslugaForm addUslugaForm = new AddUslugaForm(UslugiTable, uslugi);
            addUslugaForm.ShowDialog();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm(ClientsTable, clients);
            addClientForm.ShowDialog();
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm(OrdersTable, orders, uslugi, clients);
            addOrderForm.ShowDialog();
        }

        private void ClientsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ClientsTable.Columns["MoreInfo"].Index && e.RowIndex >= 0)
            {
                string message = "";
                if (clients[e.RowIndex] is FizLitso fiz)
                {
                    message = $"Тип: {fiz.type}\n" +
                        $"ФИО: {fiz.fio}\n" +
                        $"Email: {fiz.email}\n" +
                        $"Дата рождения: {fiz.birthday}\n" +
                        $"Паспортные данные: {fiz.passport}\n" +
                        $"Телефон: {fiz.phone}";
                }else if (clients[e.RowIndex] is YurLitso yur)
                {
                    message = $"Тип: {yur.type}\n" +
                       $"Наименование организации: {yur.name}\n" +
                       $"ИНН: {yur.inn}\n" +
                       $"Адрес: {yur.adres}\n" +
                       $"Расчётный счёт: {yur.rs}\n" +
                       $"БИК: {yur.bik}" +
                       $"ФИО руководителя: {yur.manager}" +
                       $"Телефон контактного лица: {yur.contact}" +
                       $"Email: {yur.email}";
                }

                MessageBox.Show(message);
            }
        }
    }


    public class Validation
    {
        public string Do(Control control, Label label)
        {
            string text = "";
            if (control is ComboBox box)
            {
                if (box.SelectedItem != null)
                {
                    text = box.SelectedItem.ToString();
                }
                else if (box.SelectedItem == null)
                {
                    throw new Exception($"Выберите значение из списка {label.Text}, если их нет то добавьте {label.Text}!");
                }
            }
            else if (control is ListBox list)
            {
                text = string.Join(",", list.SelectedItems.Cast<string>());
            }
            else
            {
                text = control.Text;
            }
            if (text == string.Empty)
            {
                control.BackColor = Color.LightCoral;
                throw new Exception($"Поле {label.Text} обязательно для заполнения!");
            }
            return text;
        }
    }
}
