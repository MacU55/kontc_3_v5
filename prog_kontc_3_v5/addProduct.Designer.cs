namespace prog_kontc_3_v5
{
    partial class addProduct
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
            this.txtBoxProductsName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxKodProizvodit = new System.Windows.Forms.ComboBox();
            this.productProizvoditeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kontc_3DataSet = new prog_kontc_3_v5.kontc_3DataSet();
            this.txtBoxDescriptProduct = new System.Windows.Forms.TextBox();
            this.productProizvoditeliTableAdapter = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.productProizvoditeliTableAdapter();
            this.productsTableAdapter1 = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.productsTableAdapter();
            this.btn_addNewProduct = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.numericKolvoProductSklad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.productProizvoditeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontc_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKolvoProductSklad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxProductsName
            // 
            this.txtBoxProductsName.Location = new System.Drawing.Point(305, 79);
            this.txtBoxProductsName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxProductsName.Multiline = true;
            this.txtBoxProductsName.Name = "txtBoxProductsName";
            this.txtBoxProductsName.Size = new System.Drawing.Size(132, 24);
            this.txtBoxProductsName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Навзание товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Код производителя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество товара\r\nна складе";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Описание товара\r\n";
            // 
            // cmbBoxKodProizvodit
            // 
            this.cmbBoxKodProizvodit.DataSource = this.productProizvoditeliBindingSource;
            this.cmbBoxKodProizvodit.DisplayMember = "id_proizvoditel";
            this.cmbBoxKodProizvodit.FormattingEnabled = true;
            this.cmbBoxKodProizvodit.Location = new System.Drawing.Point(305, 139);
            this.cmbBoxKodProizvodit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxKodProizvodit.Name = "cmbBoxKodProizvodit";
            this.cmbBoxKodProizvodit.Size = new System.Drawing.Size(160, 24);
            this.cmbBoxKodProizvodit.TabIndex = 5;
            this.cmbBoxKodProizvodit.ValueMember = "id_proizvoditel";
            // 
            // productProizvoditeliBindingSource
            // 
            this.productProizvoditeliBindingSource.DataMember = "productProizvoditeli";
            this.productProizvoditeliBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.kontc_3DataSet;
            this.bindingSource1.Position = 0;
            // 
            // kontc_3DataSet
            // 
            this.kontc_3DataSet.DataSetName = "kontc_3DataSet";
            this.kontc_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBoxDescriptProduct
            // 
            this.txtBoxDescriptProduct.Location = new System.Drawing.Point(305, 293);
            this.txtBoxDescriptProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDescriptProduct.Multiline = true;
            this.txtBoxDescriptProduct.Name = "txtBoxDescriptProduct";
            this.txtBoxDescriptProduct.Size = new System.Drawing.Size(132, 24);
            this.txtBoxDescriptProduct.TabIndex = 7;
            // 
            // productProizvoditeliTableAdapter
            // 
            this.productProizvoditeliTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_addNewProduct
            // 
            this.btn_addNewProduct.AutoEllipsis = true;
            this.btn_addNewProduct.BackColor = System.Drawing.Color.Lavender;
            this.btn_addNewProduct.Location = new System.Drawing.Point(305, 371);
            this.btn_addNewProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addNewProduct.Name = "btn_addNewProduct";
            this.btn_addNewProduct.Size = new System.Drawing.Size(173, 47);
            this.btn_addNewProduct.TabIndex = 8;
            this.btn_addNewProduct.Text = "Добавить товар в базу";
            this.btn_addNewProduct.UseVisualStyleBackColor = false;
            
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Lavender;
            this.btn_cancel.Location = new System.Drawing.Point(305, 468);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(173, 47);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Выйти";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // numericKolvoProductSklad
            // 
            this.numericKolvoProductSklad.Location = new System.Drawing.Point(305, 209);
            this.numericKolvoProductSklad.Margin = new System.Windows.Forms.Padding(4);
            this.numericKolvoProductSklad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericKolvoProductSklad.Name = "numericKolvoProductSklad";
            this.numericKolvoProductSklad.Size = new System.Drawing.Size(160, 23);
            this.numericKolvoProductSklad.TabIndex = 10;
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(611, 554);
            this.Controls.Add(this.numericKolvoProductSklad);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_addNewProduct);
            this.Controls.Add(this.txtBoxDescriptProduct);
            this.Controls.Add(this.cmbBoxKodProizvodit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxProductsName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addProduct";
            this.Text = "Добавление нового товара";
            this.Load += new System.EventHandler(this.addProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productProizvoditeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontc_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKolvoProductSklad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxProductsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBoxKodProizvodit;
        private System.Windows.Forms.TextBox txtBoxDescriptProduct;
        private System.Windows.Forms.BindingSource bindingSource1;
        private kontc_3DataSet kontc_3DataSet;
        private System.Windows.Forms.BindingSource productProizvoditeliBindingSource;
        private kontc_3DataSetTableAdapters.productProizvoditeliTableAdapter productProizvoditeliTableAdapter;
        private kontc_3DataSetTableAdapters.productsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.Button btn_addNewProduct;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.NumericUpDown numericKolvoProductSklad;
    }
}