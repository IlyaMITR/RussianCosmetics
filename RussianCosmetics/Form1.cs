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
        public Form1()
        {
            InitializeComponent();
        }

        private void AddUslugaButton_Click(object sender, EventArgs e)
        {
            AddUslugaForm addUslugaForm = new AddUslugaForm(UslugiTable);
            addUslugaForm.ShowDialog();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm(ClientsTable);
            addClientForm.ShowDialog();
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
