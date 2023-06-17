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
        List<Usluga> uslugi;
        Validation validation = new Validation();
        public AddUslugaForm(DataGridView table, List<Usluga> uslugiList)
        {
            InitializeComponent();
            uslugiTable = table;
            uslugi = uslugiList;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try 
            {
                string name = validation.Do(UslugaNameText, UslugaNameLabel);
                string price = UslugaPriceNumericUpDown.Value.ToString();
                uslugi.Add(new Usluga(name, price));
                uslugiTable.Rows.Add(name, price);
                Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class Usluga 
    {
        public string name;
        public string price;
        public Usluga(string name, string price)
        {
            this.name = name;
            this.price = price;
        }
    }

}
