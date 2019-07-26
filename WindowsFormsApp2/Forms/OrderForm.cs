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
        Order Order;

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
                OrderItem orderItem = new OrderItem();
                orderItem.Quantity = int.Parse(textQuantity.Text);
                orderItem.Product = (Product)comboBoxProducts.SelectedItem;
                orderItem.Order = Order;
                orderItem.ItemName = orderItem.Product.Name;
                orderItem.ItemPrize = orderItem.Product.Prize * double.Parse(textQuantity.Text); 
                dbtc.OrderItem.Add(orderItem);
                dbtc.SaveChanges();

                MessageBox.Show("Záznam byl přidán do databáze");
                this.orderItemsTableAdapter.Fill(this.agoraSystemDataSet1.OrderItems);

            }
            catch (Exception)
            {
                MessageBox.Show("Něco se nepodařilo");
            }

        }

private void buttonSendOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order was save to system");
            comboBoxProducts.Enabled = false;
            textQuantity.Enabled = false;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'agoraSystemDataSet1.OrderItems'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.orderItemsTableAdapter.Fill(this.agoraSystemDataSet1.OrderItems);

        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order();
                comboBoxProducts.Enabled = true;
                textQuantity.Enabled = true;
                order.DateTime = DateTime.Now;
                dbtc.Order.Add(order);
                this.Order = order;
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
                this.orderItemsTableAdapter.Fill(this.agoraSystemDataSet1.OrderItems);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteOrderItem_Click(object sender, EventArgs e)
        {
            List<OrderItem> ListOrderItem = dbtc.OrderItem.ToList<OrderItem>();
            int index = dataGridViewOrderItem.CurrentRow.Index;
            OrderItem orderItem = ListOrderItem.ElementAt(index);
            dbtc.OrderItem.Remove(orderItem);
            MessageBox.Show("Dodavatel was deleted", "Delete");
            dbtc.SaveChanges();
            this.orderItemsTableAdapter.Fill(this.agoraSystemDataSet1.OrderItems);
            

        }
    }
}
