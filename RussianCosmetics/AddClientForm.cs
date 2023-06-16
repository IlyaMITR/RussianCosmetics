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
    public partial class AddClientForm : Form
    {
        DataGridView clientsTable;
        public AddClientForm(DataGridView table)
        {
            InitializeComponent();
            clientsTable = table;
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
    }
}
