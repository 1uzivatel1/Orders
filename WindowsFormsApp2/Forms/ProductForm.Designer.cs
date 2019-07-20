namespace WindowsFormsApp2
{
    partial class ProductForm
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
            this.comboBoxPDodavatel = new System.Windows.Forms.ComboBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelDodavatel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDeleteDodavatel = new System.Windows.Forms.Button();
            this.buttonNewDodavatel = new System.Windows.Forms.Button();
            this.textBoxProductPrize = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrize = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonNewProduct = new System.Windows.Forms.Button();
            this.mNDbTestContextDataSet = new WindowsFormsApp2.MNDbTestContextDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new WindowsFormsApp2.MNDbTestContextDataSetTableAdapters.ProductsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNDbTestContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPDodavatel
            // 
            this.comboBoxPDodavatel.Enabled = false;
            this.comboBoxPDodavatel.FormattingEnabled = true;
            this.comboBoxPDodavatel.Location = new System.Drawing.Point(3, 31);
            this.comboBoxPDodavatel.Name = "comboBoxPDodavatel";
            this.comboBoxPDodavatel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPDodavatel.TabIndex = 0;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Enabled = false;
            this.buttonAddProduct.Location = new System.Drawing.Point(12, 254);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProduct.TabIndex = 1;
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Enabled = false;
            this.textBoxProductName.Location = new System.Drawing.Point(3, 87);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductName.TabIndex = 2;
            // 
            // labelDodavatel
            // 
            this.labelDodavatel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDodavatel.AutoSize = true;
            this.labelDodavatel.Enabled = false;
            this.labelDodavatel.Location = new System.Drawing.Point(3, 15);
            this.labelDodavatel.Name = "labelDodavatel";
            this.labelDodavatel.Size = new System.Drawing.Size(56, 13);
            this.labelDodavatel.TabIndex = 3;
            this.labelDodavatel.Text = "Dodavatel";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.79124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.26263F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.28283F));
            this.tableLayoutPanel1.Controls.Add(this.buttonDeleteDodavatel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonNewDodavatel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxProductPrize, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelPrize, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxProductName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelDodavatel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPDodavatel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 169);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // buttonDeleteDodavatel
            // 
            this.buttonDeleteDodavatel.Location = new System.Drawing.Point(215, 31);
            this.buttonDeleteDodavatel.Name = "buttonDeleteDodavatel";
            this.buttonDeleteDodavatel.Size = new System.Drawing.Size(75, 22);
            this.buttonDeleteDodavatel.TabIndex = 5;
            this.buttonDeleteDodavatel.Text = "Delete";
            this.buttonDeleteDodavatel.UseVisualStyleBackColor = true;
            this.buttonDeleteDodavatel.Click += new System.EventHandler(this.buttonDeleteDodavatel_Click);
            // 
            // buttonNewDodavatel
            // 
            this.buttonNewDodavatel.Location = new System.Drawing.Point(138, 31);
            this.buttonNewDodavatel.Name = "buttonNewDodavatel";
            this.buttonNewDodavatel.Size = new System.Drawing.Size(71, 22);
            this.buttonNewDodavatel.TabIndex = 6;
            this.buttonNewDodavatel.Text = "New";
            this.buttonNewDodavatel.UseVisualStyleBackColor = true;
            this.buttonNewDodavatel.Click += new System.EventHandler(this.buttonNewDodavatel_Click);
            // 
            // textBoxProductPrize
            // 
            this.textBoxProductPrize.Enabled = false;
            this.textBoxProductPrize.Location = new System.Drawing.Point(3, 143);
            this.textBoxProductPrize.Name = "textBoxProductPrize";
            this.textBoxProductPrize.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductPrize.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Enabled = false;
            this.labelName.Location = new System.Drawing.Point(3, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // labelPrize
            // 
            this.labelPrize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPrize.AutoSize = true;
            this.labelPrize.Enabled = false;
            this.labelPrize.Location = new System.Drawing.Point(3, 127);
            this.labelPrize.Name = "labelPrize";
            this.labelPrize.Size = new System.Drawing.Size(30, 13);
            this.labelPrize.TabIndex = 7;
            this.labelPrize.Text = "Prize";
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AutoGenerateColumns = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewProduct.DataSource = this.productsBindingSource;
            this.dataGridViewProduct.Location = new System.Drawing.Point(362, 52);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(436, 169);
            this.dataGridViewProduct.TabIndex = 5;
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(725, 254);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteProduct.TabIndex = 6;
            this.buttonDeleteProduct.Text = "Delete";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonNewProduct
            // 
            this.buttonNewProduct.Location = new System.Drawing.Point(12, 13);
            this.buttonNewProduct.Name = "buttonNewProduct";
            this.buttonNewProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonNewProduct.TabIndex = 7;
            this.buttonNewProduct.Text = "New";
            this.buttonNewProduct.UseVisualStyleBackColor = true;
            this.buttonNewProduct.Click += new System.EventHandler(this.buttonNewProduct_Click);
            // 
            // mNDbTestContextDataSet
            // 
            this.mNDbTestContextDataSet.DataSetName = "MNDbTestContextDataSet";
            this.mNDbTestContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.mNDbTestContextDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prize";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prize";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Dodavatel_Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dodavatel_Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 289);
            this.Controls.Add(this.buttonNewProduct);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonAddProduct);
            this.Name = "ProductForm";
            this.Text = "Product";
            this.Activated += new System.EventHandler(this.ProductForm_Activated);
            this.Load += new System.EventHandler(this.NewProduct_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNDbTestContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPDodavatel;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelDodavatel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxProductPrize;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrize;
        private System.Windows.Forms.Button buttonDeleteDodavatel;
        private System.Windows.Forms.Button buttonNewDodavatel;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodavatelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonNewProduct;
        private MNDbTestContextDataSet mNDbTestContextDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private MNDbTestContextDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}