namespace prog_kontc_3_v5
{
    partial class addProizvoditel
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
            this.txbNameProizvodirel = new System.Windows.Forms.TextBox();
            this.btnAddProizvoditel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.kontc_3DataSet = new prog_kontc_3_v5.kontc_3DataSet();
            this.productProizvoditeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productProizvoditeliTableAdapter = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.productProizvoditeliTableAdapter();
            this.tableAdapterManager = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.kontc_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productProizvoditeliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 41);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Название производителя";
            // 
            // txbNameProizvodirel
            // 
            this.txbNameProizvodirel.Location = new System.Drawing.Point(258, 72);
            this.txbNameProizvodirel.Multiline = true;
            this.txbNameProizvodirel.Name = "txbNameProizvodirel";
            this.txbNameProizvodirel.Size = new System.Drawing.Size(119, 31);
            this.txbNameProizvodirel.TabIndex = 1;
            // 
            // btnAddProizvoditel
            // 
            this.btnAddProizvoditel.Location = new System.Drawing.Point(50, 216);
            this.btnAddProizvoditel.Name = "btnAddProizvoditel";
            this.btnAddProizvoditel.Size = new System.Drawing.Size(134, 60);
            this.btnAddProizvoditel.TabIndex = 2;
            this.btnAddProizvoditel.Text = "Добавить производителя";
            this.btnAddProizvoditel.UseVisualStyleBackColor = true;
            this.btnAddProizvoditel.Click += new System.EventHandler(this.btnAddProizvoditel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(274, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 60);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Выйти";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // kontc_3DataSet
            // 
            this.kontc_3DataSet.DataSetName = "kontc_3DataSet";
            this.kontc_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productProizvoditeliBindingSource
            // 
            this.productProizvoditeliBindingSource.DataMember = "productProizvoditeli";
            this.productProizvoditeliBindingSource.DataSource = this.kontc_3DataSet;
            // 
            // productProizvoditeliTableAdapter
            // 
            this.productProizvoditeliTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pokupateliTableAdapter = null;
            this.tableAdapterManager.postavshikiTableAdapter = null;
            this.tableAdapterManager.prodazhiTableAdapter = null;
            this.tableAdapterManager.productProizvoditeliTableAdapter = this.productProizvoditeliTableAdapter;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prog_kontc_3_v5.kontc_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zakupkiTableAdapter = null;
            // 
            // addProizvoditel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 399);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddProizvoditel);
            this.Controls.Add(this.txbNameProizvodirel);
            this.Controls.Add(this.textBox1);
            this.Name = "addProizvoditel";
            this.Text = " ";
            this.Load += new System.EventHandler(this.addProizvoditel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kontc_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productProizvoditeliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txbNameProizvodirel;
        private System.Windows.Forms.Button btnAddProizvoditel;
        private System.Windows.Forms.Button btnCancel;
        private kontc_3DataSet kontc_3DataSet;
        private System.Windows.Forms.BindingSource productProizvoditeliBindingSource;
        private kontc_3DataSetTableAdapters.productProizvoditeliTableAdapter productProizvoditeliTableAdapter;
        private kontc_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}