namespace WindowsFormsApp2
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelProduct = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.buttonNewProduct = new System.Windows.Forms.Button();
            this.buttonDeleteOrderItem = new System.Windows.Forms.Button();
            this.buttonSendOrder = new System.Windows.Forms.Button();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.dataGridViewOrderItem = new System.Windows.Forms.DataGridView();
            this.radioButtonLastOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.agoraSystemDataSet1 = new WindowsFormsApp2.AgoraSystemDataSet1();
            this.orderItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemsTableAdapter = new WindowsFormsApp2.AgoraSystemDataSet1TableAdapters.OrderItemsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agoraSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProduct
            // 
            this.labelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(3, 19);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(44, 13);
            this.labelProduct.TabIndex = 1;
            this.labelProduct.Text = "Product";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxProducts.Enabled = false;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(3, 37);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProducts.TabIndex = 2;
            this.comboBoxProducts.Text = "Vyber produkt...";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.05634F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.64789F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.94366F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelProduct, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxProducts, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textQuantity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonNewProduct, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 102);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 64);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity";
            // 
            // textQuantity
            // 
            this.textQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textQuantity.Enabled = false;
            this.textQuantity.Location = new System.Drawing.Point(131, 38);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(36, 20);
            this.textQuantity.TabIndex = 7;
            // 
            // buttonNewProduct
            // 
            this.buttonNewProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonNewProduct.Location = new System.Drawing.Point(183, 36);
            this.buttonNewProduct.Name = "buttonNewProduct";
            this.buttonNewProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonNewProduct.TabIndex = 8;
            this.buttonNewProduct.Text = "New";
            this.buttonNewProduct.UseVisualStyleBackColor = true;
            this.buttonNewProduct.Click += new System.EventHandler(this.buttonNewProduct_Click);
            // 
            // buttonDeleteOrderItem
            // 
            this.buttonDeleteOrderItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDeleteOrderItem.Location = new System.Drawing.Point(136, 186);
            this.buttonDeleteOrderItem.Name = "buttonDeleteOrderItem";
            this.buttonDeleteOrderItem.Size = new System.Drawing.Size(105, 23);
            this.buttonDeleteOrderItem.TabIndex = 9;
            this.buttonDeleteOrderItem.Text = "Delete from order";
            this.buttonDeleteOrderItem.UseVisualStyleBackColor = true;
            this.buttonDeleteOrderItem.Click += new System.EventHandler(this.buttonDeleteOrderItem_Click);
            // 
            // buttonSendOrder
            // 
            this.buttonSendOrder.Location = new System.Drawing.Point(293, 415);
            this.buttonSendOrder.Name = "buttonSendOrder";
            this.buttonSendOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonSendOrder.TabIndex = 5;
            this.buttonSendOrder.Text = "Send order";
            this.buttonSendOrder.UseVisualStyleBackColor = true;
            this.buttonSendOrder.Click += new System.EventHandler(this.buttonSendOrder_Click);
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Location = new System.Drawing.Point(25, 186);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(105, 23);
            this.buttonAddToOrder.TabIndex = 6;
            this.buttonAddToOrder.Text = "Add to order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.Location = new System.Drawing.Point(25, 53);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonNewOrder.TabIndex = 7;
            this.buttonNewOrder.Text = "New Order";
            this.buttonNewOrder.UseVisualStyleBackColor = true;
            this.buttonNewOrder.Click += new System.EventHandler(this.buttonNewOrder_Click);
            // 
            // dataGridViewOrderItem
            // 
            this.dataGridViewOrderItem.AutoGenerateColumns = false;
            this.dataGridViewOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridViewOrderItem.DataSource = this.orderItemsBindingSource;
            this.dataGridViewOrderItem.Location = new System.Drawing.Point(25, 218);
            this.dataGridViewOrderItem.Name = "dataGridViewOrderItem";
            this.dataGridViewOrderItem.Size = new System.Drawing.Size(760, 171);
            this.dataGridViewOrderItem.TabIndex = 3;
            // 
            // radioButtonLastOrder
            // 
            this.radioButtonLastOrder.AutoSize = true;
            this.radioButtonLastOrder.Location = new System.Drawing.Point(660, 192);
            this.radioButtonLastOrder.Name = "radioButtonLastOrder";
            this.radioButtonLastOrder.Size = new System.Drawing.Size(74, 17);
            this.radioButtonLastOrder.TabIndex = 12;
            this.radioButtonLastOrder.Text = "Last Order";
            this.radioButtonLastOrder.UseVisualStyleBackColor = true;
            this.radioButtonLastOrder.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(749, 192);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(36, 17);
            this.radioButtonAll.TabIndex = 13;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // agoraSystemDataSet1
            // 
            this.agoraSystemDataSet1.DataSetName = "AgoraSystemDataSet1";
            this.agoraSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderItemsBindingSource
            // 
            this.orderItemsBindingSource.DataMember = "OrderItems";
            this.orderItemsBindingSource.DataSource = this.agoraSystemDataSet1;
            // 
            // orderItemsTableAdapter
            // 
            this.orderItemsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ItemName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ItemPrize";
            this.dataGridViewTextBoxColumn4.HeaderText = "ItemPrize";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Stredisko";
            this.dataGridViewTextBoxColumn5.HeaderText = "Stredisko";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Product_Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Product_Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Order_Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Order_Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 458);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.radioButtonLastOrder);
            this.Controls.Add(this.buttonNewOrder);
            this.Controls.Add(this.buttonAddToOrder);
            this.Controls.Add(this.buttonSendOrder);
            this.Controls.Add(this.buttonDeleteOrderItem);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridViewOrderItem);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agoraSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Button buttonNewProduct;
        private System.Windows.Forms.Button buttonDeleteOrderItem;
        private System.Windows.Forms.Button buttonSendOrder;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.Button buttonNewOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrderItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strediskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton radioButtonLastOrder;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private AgoraSystemDataSet1 agoraSystemDataSet1;
        private System.Windows.Forms.BindingSource orderItemsBindingSource;
        private AgoraSystemDataSet1TableAdapters.OrderItemsTableAdapter orderItemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}