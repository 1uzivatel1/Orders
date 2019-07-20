using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DodavatelForm : Form
    {
        DbTestContext dbtc = new DbTestContext();
        Dodavatel dodavatel = new Dodavatel();

        public DodavatelForm(ProductForm pf)
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddToDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                dodavatel.Name = textBoxName.Text;
                dodavatel.PhoneNumber = textBoxPhone.Text;
                dodavatel.Email = textBoxEmail.Text;
                dbtc.Dodavatel.Add(dodavatel);
                dbtc.SaveChanges();
                
                MessageBox.Show("Záznam byl přidán do databáze");

            }
            catch (Exception)
            {
                MessageBox.Show("Něco se nepodařilo");
            }
            Close();

        }

        private void buttonDeleteFromDatabase_Click(object sender, EventArgs e)
        {


        }

    }
}
