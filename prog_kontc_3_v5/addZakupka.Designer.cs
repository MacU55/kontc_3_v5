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
            this.cmbIdProduct = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kontc_3DataSet = new prog_kontc_3_v5.kontc_3DataSet();
            this.productsTableAdapter = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.productsTableAdapter();
            this.cmbIdPostavshik = new System.Windows.Forms.ComboBox();
            this.postavshikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikiTableAdapter = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.postavshikiTableAdapter();
            this.dateZakupka = new System.Windows.Forms.DateTimePicker();
            this.numPriceProduct = new System.Windows.Forms.NumericUpDown();
            this.numericKolvoProduct = new System.Windows.Forms.NumericUpDown();
            this.numericPriceFactor = new System.Windows.Forms.NumericUpDown();
            this.btnCreateZakupka = new System.Windows.Forms.Button();
            this.zakupkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakupkiTableAdapter = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.zakupkiTableAdapter();
            this.tableAdapterManager = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontc_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKolvoProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Код продукта";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Код поставщика";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Дата закупки";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 258);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(170, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Цена товара (0...10000)";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(90, 317);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(170, 33);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Количество закупаемого товара (0...1000)";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(90, 386);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(170, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Ценовой коэффициент (0...100)";
            // 
            // cmbIdProduct
            // 
            this.cmbIdProduct.DataSource = this.productsBindingSource;
            this.cmbIdProduct.DisplayMember = "id_product";
            this.cmbIdProduct.FormattingEnabled = true;
            this.cmbIdProduct.Location = new System.Drawing.Point(311, 75);
            this.cmbIdProduct.Name = "cmbIdProduct";
            this.cmbIdProduct.Size = new System.Drawing.Size(121, 21);
            this.cmbIdProduct.TabIndex = 6;
            this.cmbIdProduct.ValueMember = "id_product";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.kontc_3DataSet;
            // 
            // kontc_3DataSet
            // 
            this.kontc_3DataSet.DataSetName = "kontc_3DataSet";
            this.kontc_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // cmbIdPostavshik
            // 
            this.cmbIdPostavshik.DataSource = this.postavshikiBindingSource;
            this.cmbIdPostavshik.DisplayMember = "id_postavshik";
            this.cmbIdPostavshik.FormattingEnabled = true;
            this.cmbIdPostavshik.Location = new System.Drawing.Point(311, 131);
            this.cmbIdPostavshik.Name = "cmbIdPostavshik";
            this.cmbIdPostavshik.Size = new System.Drawing.Size(121, 21);
            this.cmbIdPostavshik.TabIndex = 7;
            this.cmbIdPostavshik.ValueMember = "id_postavshik";
            // 
            // postavshikiBindingSource
            // 
            this.postavshikiBindingSource.DataMember = "postavshiki";
            this.postavshikiBindingSource.DataSource = this.kontc_3DataSet;
            // 
            // postavshikiTableAdapter
            // 
            this.postavshikiTableAdapter.ClearBeforeFill = true;
            // 
            // dateZakupka
            // 
            this.dateZakupka.Location = new System.Drawing.Point(311, 186);
            this.dateZakupka.Name = "dateZakupka";
            this.dateZakupka.Size = new System.Drawing.Size(200, 20);
            this.dateZakupka.TabIndex = 8;
            // 
            // numPriceProduct
            // 
            this.numPriceProduct.DecimalPlaces = 2;
            this.numPriceProduct.Location = new System.Drawing.Point(311, 258);
            this.numPriceProduct.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPriceProduct.Name = "numPriceProduct";
            this.numPriceProduct.Size = new System.Drawing.Size(120, 20);
            this.numPriceProduct.TabIndex = 9;
            this.numPriceProduct.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericKolvoProduct
            // 
            this.numericKolvoProduct.Location = new System.Drawing.Point(311, 330);
            this.numericKolvoProduct.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericKolvoProduct.Name = "numericKolvoProduct";
            this.numericKolvoProduct.Size = new System.Drawing.Size(120, 20);
            this.numericKolvoProduct.TabIndex = 10;
            this.numericKolvoProduct.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericPriceFactor
            // 
            this.numericPriceFactor.DecimalPlaces = 2;
            this.numericPriceFactor.Location = new System.Drawing.Point(312, 386);
            this.numericPriceFactor.Name = "numericPriceFactor";
            this.numericPriceFactor.Size = new System.Drawing.Size(120, 20);
            this.numericPriceFactor.TabIndex = 11;
            // 
            // btnCreateZakupka
            // 
            this.btnCreateZakupka.Location = new System.Drawing.Point(528, 415);
            this.btnCreateZakupka.Name = "btnCreateZakupka";
            this.btnCreateZakupka.Size = new System.Drawing.Size(121, 53);
            this.btnCreateZakupka.TabIndex = 12;
            this.btnCreateZakupka.Text = "Создать закупку";
            this.btnCreateZakupka.UseVisualStyleBackColor = true;
            this.btnCreateZakupka.Click += new System.EventHandler(this.btnCreateZakupka_Click);
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
            this.tableAdapterManager.postavshikiTableAdapter = this.postavshikiTableAdapter;
            this.tableAdapterManager.prodazhiTableAdapter = null;
            this.tableAdapterManager.productProizvoditeliTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = prog_kontc_3_v5.kontc_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zakupkiTableAdapter = this.zakupkiTableAdapter;
            // 
            // addZakupka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(874, 723);
            this.Controls.Add(this.btnCreateZakupka);
            this.Controls.Add(this.numericPriceFactor);
            this.Controls.Add(this.numericKolvoProduct);
            this.Controls.Add(this.numPriceProduct);
            this.Controls.Add(this.dateZakupka);
            this.Controls.Add(this.cmbIdPostavshik);
            this.Controls.Add(this.cmbIdProduct);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "addZakupka";
            this.Text = "addZakupka";
            this.Load += new System.EventHandler(this.addZakupka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontc_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKolvoProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkiBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbIdProduct;
        private kontc_3DataSet kontc_3DataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private kontc_3DataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.ComboBox cmbIdPostavshik;
        private System.Windows.Forms.BindingSource postavshikiBindingSource;
        private kontc_3DataSetTableAdapters.postavshikiTableAdapter postavshikiTableAdapter;
        private System.Windows.Forms.DateTimePicker dateZakupka;
        private System.Windows.Forms.NumericUpDown numPriceProduct;
        private System.Windows.Forms.NumericUpDown numericKolvoProduct;
        private System.Windows.Forms.NumericUpDown numericPriceFactor;
        private System.Windows.Forms.Button btnCreateZakupka;
        private System.Windows.Forms.BindingSource zakupkiBindingSource;
        private kontc_3DataSetTableAdapters.zakupkiTableAdapter zakupkiTableAdapter;
        private kontc_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}