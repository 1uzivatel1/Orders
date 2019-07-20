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
    public partial class OrderForm : Form
        
    {
        DbTestContext dbtc = new DbTestContext();
        OrderItem orderItem = new OrderItem();
        Order order = new Order();
        List<OrderItem> oiL = new List<OrderItem>();

        public OrderForm()
        {
            InitializeComponent();
        }

        private void buttonNewProduct_Click(object sender, EventArgs e)
        {
                ProductForm formP = new ProductForm(this);
                formP.ShowDialog();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            try
            {
                comboBoxProducts.DataSource = dbtc.Product.ToList<Product>();
                comboBoxProducts.DisplayMember = "Name";
                comboBoxProducts.Invalidate();

            }
            catch (Exception)
            {
                MessageBox.Show("Problem s pripojenim do databaze");
            }
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                orderItem.Quantity = int.Parse(textQuantity.Text);
                orderItem.Product = (Product)comboBoxProducts.SelectedItem;
                dbtc.OrderItem.Add(orderItem);
                dbtc.SaveChanges();
                this.orderItemsTableAdapter.Fill(this.mNDbTestContextDataSet.OrderItems);

                MessageBox.Show("Záznam byl přidán do databáze");

            }
            catch (Exception)
            {
                MessageBox.Show("Něco se nepodařilo");
            }

        }

private void buttonSendOrder_Click(object sender, EventArgs e)
        {
            //var DotazMax = ltscdc.OrderItems.Max(OI => OI.Order_Id);
            //var Dotaz = ltscdc.OrderItems.Where(OI => OI.Order_Id == DotazMax ).Sum(OI => OI.ItemPrize);
            MessageBox.Show("Order was save to system");
            comboBoxProducts.Enabled = false;
            textQuantity.Enabled = false;
            //labelProduct.Text = Dotaz.ToString(); 
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'mNDbTestContextDataSet.OrderItems'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.orderItemsTableAdapter.Fill(this.mNDbTestContextDataSet.OrderItems);
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                comboBoxProducts.Enabled = true;
                textQuantity.Enabled = true;
                order.DateTime = DateTime.Now;
                dbtc.Order.Add(order);
                dbtc.SaveChanges();   
            }
            catch (Exception)
            {
                MessageBox.Show("Něco se nepodařilo");
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.orderItemsTableAdapter.Fill(this.mNDbTestContextDataSet.OrderItems);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteOrderItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            oiL = dbtc.OrderItem.ToList();
            int index = dataGridViewOrderItem.CurrentRow.Index;
                //OrderItem oi = oiL.ElementAt(index);
                labelProduct.Text = index.ToString();
                //dbtc.OrderItem.Remove(oi);
                //MessageBox.Show("Order item was deleted", "Delete");
                //dbtc.SaveChanges();
                //this.orderItemsTableAdapter.Fill(this.dataOrderItem.OrderItems);
        //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Problem with deleting order item", "Delete");
            //}
}
    }
}
