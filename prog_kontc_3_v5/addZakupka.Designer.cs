namespace prog_kontc_3_v5
{
    partial class addZakupka
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.kontc_3DataSet = new prog_kontc_3_v5.kontc_3DataSet();
            this.zakupkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakupkiTableAdapter = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.zakupkiTableAdapter();
            this.tableAdapterManager = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.TableAdapterManager();
            this.numPriceZakupka = new System.Windows.Forms.NumericUpDown();
            this.numPriceFactor = new System.Windows.Forms.NumericUpDown();
            this.dateTimeZakupka = new System.Windows.Forms.DateTimePicker();
            this.cmbIdProduct = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbIdPostavshik = new System.Windows.Forms.ComboBox();
            this.postavshikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numKolvoZakupka = new System.Windows.Forms.NumericUpDown();
            this.productsTableAdapter = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.productsTableAdapter();
            this.postavshikiTableAdapter = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.postavshikiTableAdapter();
            this.btnCreateZakupka = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kontc_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceZakupka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolvoZakupka)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Код продукта";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Код поставщика";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(50, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Дата закупки";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(50, 262);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 46);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Цена закупки единицы товара\r\n(0.01...10000)";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(50, 326);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Количество товара";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(50, 394);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(130, 36);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Ценовой коэффициент\r\n(0,1...10,99)";
            // 
            // kontc_3DataSet
            // 
            this.kontc_3DataSet.DataSetName = "kontc_3DataSet";
            this.kontc_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zakupkiBindingSource
            // 
            this.zakupkiBindingSource.DataMember = "zakupki";
            this.zakupkiBindingSource.DataSource = this.kontc_3DataSet;
            // 
            // zakupkiTableAdapter
            // 
            this.zakupkiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pokupateliTableAdapter = null;
            this.tableAdapterManager.postavshikiTableAdapter = null;
            this.tableAdapterManager.prodazhiTableAdapter = null;
            this.tableAdapterManager.productProizvoditeliTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prog_kontc_3_v5.kontc_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zakupkiTableAdapter = this.zakupkiTableAdapter;
            // 
            // numPriceZakupka
            // 
            this.numPriceZakupka.DecimalPlaces = 2;
            this.numPriceZakupka.Location = new System.Drawing.Point(287, 263);
            this.numPriceZakupka.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPriceZakupka.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPriceZakupka.Name = "numPriceZakupka";
            this.numPriceZakupka.Size = new System.Drawing.Size(120, 20);
            this.numPriceZakupka.TabIndex = 6;
            this.numPriceZakupka.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numPriceFactor
            // 
            this.numPriceFactor.DecimalPlaces = 2;
            this.numPriceFactor.Location = new System.Drawing.Point(287, 410);
            this.numPriceFactor.Maximum = new decimal(new int[] {
            1099,
            0,
            0,
            131072});
            this.numPriceFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPriceFactor.Name = "numPriceFactor";
            this.numPriceFactor.Size = new System.Drawing.Size(120, 20);
            this.numPriceFactor.TabIndex = 7;
            this.numPriceFactor.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // dateTimeZakupka
            // 
            this.dateTimeZakupka.Location = new System.Drawing.Point(287, 197);
            this.dateTimeZakupka.Name = "dateTimeZakupka";
            this.dateTimeZakupka.Size = new System.Drawing.Size(200, 20);
            this.dateTimeZakupka.TabIndex = 8;
            // 
            // cmbIdProduct
            // 
            this.cmbIdProduct.DataSource = this.productsBindingSource;
            this.cmbIdProduct.DisplayMember = "id_product";
            this.cmbIdProduct.FormattingEnabled = true;
            this.cmbIdProduct.Location = new System.Drawing.Point(286, 55);
            this.cmbIdProduct.Name = "cmbIdProduct";
            this.cmbIdProduct.Size = new System.Drawing.Size(121, 21);
            this.cmbIdProduct.TabIndex = 9;
            this.cmbIdProduct.ValueMember = "id_product";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.kontc_3DataSet;
            // 
            // cmbIdPostavshik
            // 
            this.cmbIdPostavshik.DataSource = this.postavshikiBindingSource;
            this.cmbIdPostavshik.DisplayMember = "id_postavshik";
            this.cmbIdPostavshik.FormattingEnabled = true;
            this.cmbIdPostavshik.Location = new System.Drawing.Point(286, 123);
            this.cmbIdPostavshik.Name = "cmbIdPostavshik";
            this.cmbIdPostavshik.Size = new System.Drawing.Size(121, 21);
            this.cmbIdPostavshik.TabIndex = 10;
            this.cmbIdPostavshik.ValueMember = "id_postavshik";
            // 
            // postavshikiBindingSource
            // 
            this.postavshikiBindingSource.DataMember = "postavshiki";
            this.postavshikiBindingSource.DataSource = this.kontc_3DataSet;
            // 
            // numKolvoZakupka
            // 
            this.numKolvoZakupka.Location = new System.Drawing.Point(287, 327);
            this.numKolvoZakupka.Name = "numKolvoZakupka";
            this.numKolvoZakupka.Size = new System.Drawing.Size(120, 20);
            this.numKolvoZakupka.TabIndex = 11;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // postavshikiTableAdapter
            // 
            this.postavshikiTableAdapter.ClearBeforeFill = true;
            // 
            // btnCreateZakupka
            // 
            this.btnCreateZakupka.Location = new System.Drawing.Point(567, 326);
            this.btnCreateZakupka.Name = "btnCreateZakupka";
            this.btnCreateZakupka.Size = new System.Drawing.Size(120, 56);
            this.btnCreateZakupka.TabIndex = 12;
            this.btnCreateZakupka.Text = "Создать закупку";
            this.btnCreateZakupka.UseVisualStyleBackColor = true;
            this.btnCreateZakupka.Click += new System.EventHandler(this.btnCreateZakupka_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(567, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 43);
            this.button2.TabIndex = 13;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addZakupka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreateZakupka);
            this.Controls.Add(this.numKolvoZakupka);
            this.Controls.Add(this.cmbIdPostavshik);
            this.Controls.Add(this.cmbIdProduct);
            this.Controls.Add(this.dateTimeZakupka);
            this.Controls.Add(this.numPriceFactor);
            this.Controls.Add(this.numPriceZakupka);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "addZakupka";
            this.Text = "Создание закупки";
            this.Load += new System.EventHandler(this.addZakupka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kontc_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceZakupka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolvoZakupka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private kontc_3DataSet kontc_3DataSet;
        private System.Windows.Forms.BindingSource zakupkiBindingSource;
        private kontc_3DataSetTableAdapters.zakupkiTableAdapter zakupkiTableAdapter;
        private kontc_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.NumericUpDown numPriceZakupka;
        private System.Windows.Forms.NumericUpDown numPriceFactor;
        private System.Windows.Forms.DateTimePicker dateTimeZakupka;
        private System.Windows.Forms.ComboBox cmbIdProduct;
        private System.Windows.Forms.ComboBox cmbIdPostavshik;
        private System.Windows.Forms.NumericUpDown numKolvoZakupka;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private kontc_3DataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource postavshikiBindingSource;
        private kontc_3DataSetTableAdapters.postavshikiTableAdapter postavshikiTableAdapter;
        private System.Windows.Forms.Button btnCreateZakupka;
        private System.Windows.Forms.Button button2;
    }
}