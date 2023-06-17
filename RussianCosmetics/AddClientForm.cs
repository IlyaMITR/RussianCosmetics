using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RussianCosmetics
{
    


    public partial class AddClientForm : Form
    {
        DataGridView clientsTable;
        List<Client> clients;
        Validation validation = new Validation();

        public AddClientForm(DataGridView table, List<Client> clientsList)
        {
            InitializeComponent();
            clientsTable = table;
            clients = clientsList;
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            ClientTypeComboBox.SelectedItem = ClientTypeComboBox.Items[0];
            FizPanel.Visible = true;
        }

        private void ClientTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientTypeComboBox.SelectedIndex == 0)
            {
                UrPanel.Visible = false;
                FizPanel.Visible = true;
            }
            else if (ClientTypeComboBox.SelectedIndex == 1)
            {
                UrPanel.Visible = true;
                FizPanel.Visible = false;
            }
        }

        private void ClientCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                string type = validation.Do(ClientTypeComboBox, ClientTypeLabel);
                string fio = validation.Do(ClientNameText, ClientNameLabel);
                string email = validation.Do(ClientEmailText, ClientEmailLabel);
                string birthday = ClientBirthDayPicker.Text;
                string passport = validation.Do(ClientPassportText, ClientPassportLabel);
                string phone = validation.Do(ClientPhoneText, ClientPhoneLabel);
                FizLitso client = new FizLitso(type, fio, email, birthday, passport, phone);
                clients.Add(client);
                clientsTable.Rows.Add(fio, type, email, phone);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddCompanyButton_Click(object sender, EventArgs e)
        {
            try
            {
                string type = validation.Do(ClientTypeComboBox, ClientTypeLabel);
                string name = validation.Do(CompanyNameText, CompanyNameLabel);
                string inn = validation.Do(CompanyINNText, CompanyINNLabel);
                string adres = validation.Do(CompanyAdressText, CompanyAdressLabel);
                string rs = validation.Do(CompanyRSText, CompanyRSLabel);
                string bik = validation.Do(CompanyBIKText, CompanyBIKLabel);
                string manager = validation.Do(CompanyManagerNameText, CompanyManagerNameLabel);
                string contact = validation.Do(CompanyContactPhoneText, CompanyContactNameLabel);
                string email = validation.Do(CompanyEmailText, CompanyEmailLabel);
                YurLitso company = new YurLitso(type, name, inn, adres, rs, bik, manager, contact, email);
                clients.Add(company);
                clientsTable.Rows.Add(name, type, email, contact);
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class Client
    {
        public string type;
        public string fio;
    }

    public class FizLitso: Client
    {
        public string email;
        public string birthday;
        public string passport;
        public string phone;
        public FizLitso(
            string type,
            string fio,
            string email,
            string birthday,
            string passport,
            string phone
            ) 
        { 
            this.type = type;
            this.fio = fio;
            this.email = email;
            this.birthday = birthday;
            this.passport = passport;
            this.phone = phone;
        }
    }

    public class YurLitso: Client
    {
        public string name;
        public string inn;
        public string adres;
        public string rs;
        public string bik;
        public string manager;
        public string contact;
        public string email;
        public YurLitso(
            string type,
            string name,
            string inn,
            string adres,
            string rs,
            string bik,
            string manager,
            string contact,
            string email
            )
        {
            this.type = type;
            this.name = name;
            this.inn = inn;
            this.adres = adres;
            this.rs = rs;
            this.bik = bik;
            this.manager = manager;
            this.contact = contact;
            this.email = email;
        }
    }
}
