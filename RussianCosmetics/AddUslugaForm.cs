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
    public partial class AddUslugaForm : Form
    {
        DataGridView uslugiTable;
        public AddUslugaForm(DataGridView table)
        {
            InitializeComponent();
            uslugiTable = table;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try 
            {
                string name = UslugaNameText.Text;
                if (name == string.Empty)
                {
                    UslugaNameText.BackColor = Color.LightCoral;
                    throw new Exception("Напишите название услуги!");
                }
                string price = UslugaPriceNumericUpDown.Value.ToString();
                uslugiTable.Rows.Add(name, price);
                Close();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
