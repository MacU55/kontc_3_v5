namespace prog_kontc_3_v5
{
    partial class addPostavshik
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
            this.postavshikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikiTableAdapter = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.postavshikiTableAdapter();
            this.tableAdapterManager = new prog_kontc_3_v5.kontc_3DataSetTableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txbNamePostavshik = new System.Windows.Forms.TextBox();
            this.txbPhonePostavshik = new System.Windows.Forms.TextBox();
            this.txbEmailPostavshik = new System.Windows.Forms.TextBox();
            this.btnCreatePostavshik = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kontc_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kontc_3DataSet
            // 
            this.kontc_3DataSet.DataSetName = "kontc_3DataSet";
            this.kontc_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pokupateliTableAdapter = null;
            this.tableAdapterManager.postavshikiTableAdapter = this.postavshikiTableAdapter;
            this.tableAdapterManager.prodazhiTableAdapter = null;
            this.tableAdapterManager.productProizvoditeliTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prog_kontc_3_v5.kontc_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zakupkiTableAdapter = null;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ФИО поставщика";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 121);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 37);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Телефон поставщика";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 195);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 36);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Эл. почта поставщика";
            // 
            // txbNamePostavshik
            // 
            this.txbNamePostavshik.Location = new System.Drawing.Point(239, 47);
            this.txbNamePostavshik.Multiline = true;
            this.txbNamePostavshik.Name = "txbNamePostavshik";
            this.txbNamePostavshik.Size = new System.Drawing.Size(100, 20);
            this.txbNamePostavshik.TabIndex = 3;
            // 
            // txbPhonePostavshik
            // 
            this.txbPhonePostavshik.Location = new System.Drawing.Point(239, 121);
            this.txbPhonePostavshik.Multiline = true;
            this.txbPhonePostavshik.Name = "txbPhonePostavshik";
            this.txbPhonePostavshik.Size = new System.Drawing.Size(100, 20);
            this.txbPhonePostavshik.TabIndex = 4;
            // 
            // txbEmailPostavshik
            // 
            this.txbEmailPostavshik.Location = new System.Drawing.Point(239, 195);
            this.txbEmailPostavshik.Multiline = true;
            this.txbEmailPostavshik.Name = "txbEmailPostavshik";
            this.txbEmailPostavshik.Size = new System.Drawing.Size(100, 20);
            this.txbEmailPostavshik.TabIndex = 5;
            // 
            // btnCreatePostavshik
            // 
            this.btnCreatePostavshik.Location = new System.Drawing.Point(511, 88);
            this.btnCreatePostavshik.Name = "btnCreatePostavshik";
            this.btnCreatePostavshik.Size = new System.Drawing.Size(113, 53);
            this.btnCreatePostavshik.TabIndex = 6;
            this.btnCreatePostavshik.Text = "Внести нового поставщика в базу";
            this.btnCreatePostavshik.UseVisualStyleBackColor = true;
            this.btnCreatePostavshik.Click += new System.EventHandler(this.btnCreatePostavshik_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(511, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Выйти";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // addPostavshik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreatePostavshik);
            this.Controls.Add(this.txbEmailPostavshik);
            this.Controls.Add(this.txbPhonePostavshik);
            this.Controls.Add(this.txbNamePostavshik);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "addPostavshik";
            this.Text = "Добавление нового поставщика";
            this.Load += new System.EventHandler(this.addPostavshik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kontc_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kontc_3DataSet kontc_3DataSet;
        private System.Windows.Forms.BindingSource postavshikiBindingSource;
        private kontc_3DataSetTableAdapters.postavshikiTableAdapter postavshikiTableAdapter;
        private kontc_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txbNamePostavshik;
        private System.Windows.Forms.TextBox txbPhonePostavshik;
        private System.Windows.Forms.TextBox txbEmailPostavshik;
        private System.Windows.Forms.Button btnCreatePostavshik;
        private System.Windows.Forms.Button btnCancel;
    }
}