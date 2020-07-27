namespace prog_kontc_3_v5
{
    partial class addProdazh
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
            this.kontc_3DataSet = new prog_kontc_3_v5.kontc_3DataSet();
            this.prodazhiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodazhiTableAdapter = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.prodazhiTableAdapter();
            this.tableAdapterManager = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.TableAdapterManager();
            this.pokupateliTableAdapter = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.pokupateliTableAdapter();
            this.productsTableAdapter = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.productsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cmbIdProduct = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbIdPokupatel = new System.Windows.Forms.ComboBox();
            this.pokupateliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimeProdazha = new System.Windows.Forms.DateTimePicker();
            this.numPriceProdazha = new System.Windows.Forms.NumericUpDown();
            this.numKolvoProdazha = new System.Windows.Forms.NumericUpDown();
            this.btnCreateProdazha = new System.Windows.Forms.Button();
            this.btnCancelProdazha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kontc_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodazhiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokupateliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceProdazha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolvoProdazha)).BeginInit();
            this.SuspendLayout();
            // 
            // kontc_3DataSet
            // 
            this.kontc_3DataSet.DataSetName = "kontc_3DataSet";
            this.kontc_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodazhiBindingSource
            // 
            this.prodazhiBindingSource.DataMember = "prodazhi";
            this.prodazhiBindingSource.DataSource = this.kontc_3DataSet;
            // 
            // prodazhiTableAdapter
            // 
            this.prodazhiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pokupateliTableAdapter = this.pokupateliTableAdapter;
            this.tableAdapterManager.postavshikiTableAdapter = null;
            this.tableAdapterManager.prodazhiTableAdapter = this.prodazhiTableAdapter;
            this.tableAdapterManager.productProizvoditeliTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = prog_kontc_3_v5.kontc_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zakupkiTableAdapter = null;
            // 
            // pokupateliTableAdapter
            // 
            this.pokupateliTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Код товара";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 118);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Код покупателя";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 181);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Дата продажи";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(38, 242);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 57);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Цена продажи \r\nодного товара\r\n(0,1...10 000)";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(38, 326);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(118, 41);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Количество товара для продажи";
            // 
            // cmbIdProduct
            // 
            this.cmbIdProduct.DataSource = this.productsBindingSource;
            this.cmbIdProduct.DisplayMember = "id_product";
            this.cmbIdProduct.FormattingEnabled = true;
            this.cmbIdProduct.Location = new System.Drawing.Point(218, 55);
            this.cmbIdProduct.Name = "cmbIdProduct";
            this.cmbIdProduct.Size = new System.Drawing.Size(121, 21);
            this.cmbIdProduct.TabIndex = 5;
            this.cmbIdProduct.ValueMember = "id_product";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.kontc_3DataSet;
            // 
            // cmbIdPokupatel
            // 
            this.cmbIdPokupatel.DataSource = this.pokupateliBindingSource;
            this.cmbIdPokupatel.DisplayMember = "id_pokupatel";
            this.cmbIdPokupatel.FormattingEnabled = true;
            this.cmbIdPokupatel.Location = new System.Drawing.Point(218, 118);
            this.cmbIdPokupatel.Name = "cmbIdPokupatel";
            this.cmbIdPokupatel.Size = new System.Drawing.Size(121, 21);
            this.cmbIdPokupatel.TabIndex = 6;
            this.cmbIdPokupatel.ValueMember = "id_pokupatel";
            // 
            // pokupateliBindingSource
            // 
            this.pokupateliBindingSource.DataMember = "pokupateli";
            this.pokupateliBindingSource.DataSource = this.kontc_3DataSet;
            // 
            // dateTimeProdazha
            // 
            this.dateTimeProdazha.Location = new System.Drawing.Point(218, 180);
            this.dateTimeProdazha.Name = "dateTimeProdazha";
            this.dateTimeProdazha.Size = new System.Drawing.Size(200, 20);
            this.dateTimeProdazha.TabIndex = 7;
            // 
            // numPriceProdazha
            // 
            this.numPriceProdazha.DecimalPlaces = 2;
            this.numPriceProdazha.Location = new System.Drawing.Point(219, 255);
            this.numPriceProdazha.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPriceProdazha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPriceProdazha.Name = "numPriceProdazha";
            this.numPriceProdazha.Size = new System.Drawing.Size(120, 20);
            this.numPriceProdazha.TabIndex = 8;
            this.numPriceProdazha.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numKolvoProdazha
            // 
            this.numKolvoProdazha.Location = new System.Drawing.Point(218, 327);
            this.numKolvoProdazha.Name = "numKolvoProdazha";
            this.numKolvoProdazha.Size = new System.Drawing.Size(120, 20);
            this.numKolvoProdazha.TabIndex = 9;
            // 
            // btnCreateProdazha
            // 
            this.btnCreateProdazha.Location = new System.Drawing.Point(571, 118);
            this.btnCreateProdazha.Name = "btnCreateProdazha";
            this.btnCreateProdazha.Size = new System.Drawing.Size(113, 65);
            this.btnCreateProdazha.TabIndex = 10;
            this.btnCreateProdazha.Text = "Создать продажу";
            this.btnCreateProdazha.UseVisualStyleBackColor = true;
            this.btnCreateProdazha.Click += new System.EventHandler(this.btnCreateProdazha_Click);
            // 
            // btnCancelProdazha
            // 
            this.btnCancelProdazha.Location = new System.Drawing.Point(571, 278);
            this.btnCancelProdazha.Name = "btnCancelProdazha";
            this.btnCancelProdazha.Size = new System.Drawing.Size(113, 57);
            this.btnCancelProdazha.TabIndex = 11;
            this.btnCancelProdazha.Text = "Выйти";
            this.btnCancelProdazha.UseVisualStyleBackColor = true;
            this.btnCancelProdazha.Click += new System.EventHandler(this.btnCancelProdazha_Click);
            // 
            // addProdazh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 455);
            this.Controls.Add(this.btnCancelProdazha);
            this.Controls.Add(this.btnCreateProdazha);
            this.Controls.Add(this.numKolvoProdazha);
            this.Controls.Add(this.numPriceProdazha);
            this.Controls.Add(this.dateTimeProdazha);
            this.Controls.Add(this.cmbIdPokupatel);
            this.Controls.Add(this.cmbIdProduct);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "addProdazh";
            this.Text = "Создание продажи";
            this.Load += new System.EventHandler(this.addProdazh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kontc_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodazhiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokupateliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceProdazha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolvoProdazha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kontc_3DataSet kontc_3DataSet;
        private System.Windows.Forms.BindingSource prodazhiBindingSource;
        private kontc_3DataSetTableAdapters.prodazhiTableAdapter prodazhiTableAdapter;
        private kontc_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private kontc_3DataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox cmbIdProduct;
        private System.Windows.Forms.ComboBox cmbIdPokupatel;
        private System.Windows.Forms.DateTimePicker dateTimeProdazha;
        private System.Windows.Forms.NumericUpDown numPriceProdazha;
        private System.Windows.Forms.NumericUpDown numKolvoProdazha;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private kontc_3DataSetTableAdapters.pokupateliTableAdapter pokupateliTableAdapter;
        private System.Windows.Forms.BindingSource pokupateliBindingSource;
        private System.Windows.Forms.Button btnCreateProdazha;
        private System.Windows.Forms.Button btnCancelProdazha;
    }
}