using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ProductForm : Form
    {
        DbTestContext dbtc = new DbTestContext();
        OrderForm nd;

        List<Product> Lp = new List<Product>();


        public ProductForm(OrderForm nd)
        {
            InitializeComponent();
            this.nd = nd;
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'agoraSystemDataSet.Products'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.productsTableAdapter.Fill(this.agoraSystemDataSet.Products);

            try
            {

                comboBoxPDodavatel.DataSource = dbtc.Dodavatel.ToList<Dodavatel>();
                comboBoxPDodavatel.DisplayMember = "Name";
                comboBoxPDodavatel.Invalidate();

            }
            catch (Exception)
            {
                MessageBox.Show("Problem s pripojenim do databaze");
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.Name = textBoxProductName.Text;
                product.Prize = double.Parse(textBoxProductPrize.Text);
                product.Dodavatel = (Dodavatel)comboBoxPDodavatel.SelectedItem;
                dbtc.Product.Add(product);
                dbtc.SaveChanges();
                MessageBox.Show("Záznam byl přidán do databáze");
            }
            catch (Exception)
            {
                MessageBox.Show("Něco se nepodařilo");
            }
            Close();
        }

        private void buttonNewDodavatel_Click(object sender, EventArgs e)
        {
            DodavatelForm formD = new DodavatelForm(this);
            formD.ShowDialog();
        }

        private void ProductForm_Activated(object sender, EventArgs e)
        {
            try
            {

                comboBoxPDodavatel.DataSource = dbtc.Dodavatel.ToList<Dodavatel>();
                comboBoxPDodavatel.DisplayMember = "Name";
                comboBoxPDodavatel.Invalidate();

            }
            catch (Exception)
            {
                MessageBox.Show("Problem s pripojenim do databaze");
            }
        }

        private void buttonDeleteDodavatel_Click(object sender, EventArgs e)
        {
            try
            {
                dbtc.Dodavatel.Remove((Dodavatel)comboBoxPDodavatel.SelectedItem);
                dbtc.SaveChanges();
                MessageBox.Show("Záznam byl odebran z databáze");
            }
            catch (Exception)
            {
                MessageBox.Show("Něco se nepodařilo");
            }
        }

        private void buttonNewProduct_Click(object sender, EventArgs e)
        {
            buttonAddProduct.Enabled = true;
            comboBoxPDodavatel.Enabled = true;
            textBoxProductName.Enabled = true;
            textBoxProductPrize.Enabled = true;
            labelDodavatel.Enabled = true;
            labelName.Enabled = true;
            labelPrize.Enabled = true;
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {

            List<Product> ListProducts = dbtc.Product.ToList<Product>();
            int index = dataGridViewProduct.CurrentRow.Index;
            Product product = ListProducts.ElementAt(index);
            dbtc.Product.Remove(product);
            MessageBox.Show("Product was deleted", "Delete");
            dbtc.SaveChanges();
            this.productsTableAdapter.Fill(this.agoraSystemDataSet.Products);

        }
    }
}
