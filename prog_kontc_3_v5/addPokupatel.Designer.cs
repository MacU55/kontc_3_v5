namespace prog_kontc_3_v5
{
    partial class addPokupatel
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
            this.pokupateliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokupateliTableAdapter = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.pokupateliTableAdapter();
            this.tableAdapterManager = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txb = new System.Windows.Forms.TextBox();
            this.txbNamePokupatel = new System.Windows.Forms.TextBox();
            this.txbPhonePokupatel = new System.Windows.Forms.TextBox();
            this.txbEmailPokupatel = new System.Windows.Forms.TextBox();
            this.btnCreatePokupatel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kontc_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokupateliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kontc_3DataSet
            // 
            this.kontc_3DataSet.DataSetName = "kontc_3DataSet";
            this.kontc_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokupateliBindingSource
            // 
            this.pokupateliBindingSource.DataMember = "pokupateli";
            this.pokupateliBindingSource.DataSource = this.kontc_3DataSet;
            // 
            // pokupateliTableAdapter
            // 
            this.pokupateliTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pokupateliTableAdapter = this.pokupateliTableAdapter;
            this.tableAdapterManager.postavshikiTableAdapter = null;
            this.tableAdapterManager.prodazhiTableAdapter = null;
            this.tableAdapterManager.productProizvoditeliTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prog_kontc_3_v5.kontc_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zakupkiTableAdapter = null;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ФИО покупателя";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 146);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 40);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Телефон покупателя";
            // 
            // txb
            // 
            this.txb.Location = new System.Drawing.Point(71, 233);
            this.txb.Multiline = true;
            this.txb.Name = "txb";
            this.txb.Size = new System.Drawing.Size(100, 37);
            this.txb.TabIndex = 2;
            this.txb.Text = "Эл. почта покупателя";
            // 
            // txbNamePokupatel
            // 
            this.txbNamePokupatel.Location = new System.Drawing.Point(279, 71);
            this.txbNamePokupatel.Name = "txbNamePokupatel";
            this.txbNamePokupatel.Size = new System.Drawing.Size(100, 20);
            this.txbNamePokupatel.TabIndex = 3;
            // 
            // txbPhonePokupatel
            // 
            this.txbPhonePokupatel.Location = new System.Drawing.Point(279, 166);
            this.txbPhonePokupatel.Name = "txbPhonePokupatel";
            this.txbPhonePokupatel.Size = new System.Drawing.Size(100, 20);
            this.txbPhonePokupatel.TabIndex = 4;
            // 
            // txbEmailPokupatel
            // 
            this.txbEmailPokupatel.Location = new System.Drawing.Point(279, 244);
            this.txbEmailPokupatel.Name = "txbEmailPokupatel";
            this.txbEmailPokupatel.Size = new System.Drawing.Size(100, 20);
            this.txbEmailPokupatel.TabIndex = 5;
            // 
            // btnCreatePokupatel
            // 
            this.btnCreatePokupatel.Location = new System.Drawing.Point(475, 102);
            this.btnCreatePokupatel.Name = "btnCreatePokupatel";
            this.btnCreatePokupatel.Size = new System.Drawing.Size(129, 49);
            this.btnCreatePokupatel.TabIndex = 6;
            this.btnCreatePokupatel.Text = "Внести нового покупателя в базу";
            this.btnCreatePokupatel.UseVisualStyleBackColor = true;
            this.btnCreatePokupatel.Click += new System.EventHandler(this.btnCreatePokupatel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(475, 214);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Выйти";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // addPokupatel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreatePokupatel);
            this.Controls.Add(this.txbEmailPokupatel);
            this.Controls.Add(this.txbPhonePokupatel);
            this.Controls.Add(this.txbNamePokupatel);
            this.Controls.Add(this.txb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "addPokupatel";
            this.Text = "addPokupatel";
            this.Load += new System.EventHandler(this.addPokupatel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kontc_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokupateliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kontc_3DataSet kontc_3DataSet;
        private System.Windows.Forms.BindingSource pokupateliBindingSource;
        private kontc_3DataSetTableAdapters.pokupateliTableAdapter pokupateliTableAdapter;
        private kontc_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txb;
        private System.Windows.Forms.TextBox txbNamePokupatel;
        private System.Windows.Forms.TextBox txbPhonePokupatel;
        private System.Windows.Forms.TextBox txbEmailPokupatel;
        private System.Windows.Forms.Button btnCreatePokupatel;
        private System.Windows.Forms.Button btnClose;
    }
}