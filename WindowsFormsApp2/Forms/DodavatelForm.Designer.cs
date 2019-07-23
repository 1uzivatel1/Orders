namespace WindowsFormsApp2
{
    partial class DodavatelForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonAddToDatabase = new System.Windows.Forms.Button();
            this.dodavatelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.agoraSystemDataSet2 = new WindowsFormsApp2.AgoraSystemDataSet2();
            this.dodavatelsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dodavatelsTableAdapter = new WindowsFormsApp2.AgoraSystemDataSet2TableAdapters.DodavatelsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dodavatelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agoraSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodavatelsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxPhone, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPhone, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEmail, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelEmail, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 143);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(3, 72);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(3, 56);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Phone";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(3, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(3, 118);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 6;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(3, 102);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email";
            // 
            // buttonAddToDatabase
            // 
            this.buttonAddToDatabase.Location = new System.Drawing.Point(25, 177);
            this.buttonAddToDatabase.Name = "buttonAddToDatabase";
            this.buttonAddToDatabase.Size = new System.Drawing.Size(110, 23);
            this.buttonAddToDatabase.TabIndex = 2;
            this.buttonAddToDatabase.Text = "Add to Database";
            this.buttonAddToDatabase.UseVisualStyleBackColor = true;
            this.buttonAddToDatabase.Click += new System.EventHandler(this.buttonAddToDatabase_Click);
            // 
            // dodavatelsBindingSource
            // 
            this.dodavatelsBindingSource.DataMember = "Dodavatels";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dodavatelsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(259, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // agoraSystemDataSet2
            // 
            this.agoraSystemDataSet2.DataSetName = "AgoraSystemDataSet2";
            this.agoraSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dodavatelsBindingSource1
            // 
            this.dodavatelsBindingSource1.DataMember = "Dodavatels";
            this.dodavatelsBindingSource1.DataSource = this.agoraSystemDataSet2;
            // 
            // dodavatelsTableAdapter
            // 
            this.dodavatelsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Location = new System.Drawing.Point(629, 177);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.DeleteProduct.TabIndex = 4;
            this.DeleteProduct.Text = "Delete";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // DodavatelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 228);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddToDatabase);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DodavatelForm";
            this.Text = "Dodavatel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dodavatelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agoraSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodavatelsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonAddToDatabase;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.BindingSource dodavatelsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AgoraSystemDataSet2 agoraSystemDataSet2;
        private System.Windows.Forms.BindingSource dodavatelsBindingSource1;
        private AgoraSystemDataSet2TableAdapters.DodavatelsTableAdapter dodavatelsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DeleteProduct;
    }
}

