using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog_kontc_3_v5
{
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
            productsTableAdapter1.Fill(kontc_3DataSet.products);
        }
                                       
        private void addProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.productProizvoditeli". При необходимости она может быть перемещена или удалена.
            this.productProizvoditeliTableAdapter.Fill(this.kontc_3DataSet.productProizvoditeli);

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            productsTableAdapter1.Fill(kontc_3DataSet.products);
            kontc_3DataSet.AcceptChanges();
           
            productsTableAdapter1.InsertNewProduct(txtBoxProductsName.Text, Convert.ToInt32(cmbBoxKodProizvodit.SelectedValue),
            Convert.ToInt32(numericKolvoProductSklad.Value), txtBoxDescriptProduct.Text);

            MessageBox.Show("Товар успешно внесен в базу данных товаров", "Внесение нового товара в базу", MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);

            txtBoxProductsName.Clear();
            cmbBoxKodProizvodit.SelectedIndex = 0;
            numericKolvoProductSklad.Value = 0;
            txtBoxDescriptProduct.Clear();


        }
        private void btn_cancel_Click(object sender, EventArgs e)
                
        {
            Close();
        }

        
    }
}

