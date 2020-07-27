using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog_kontc_3_v5
{
    public partial class Kontc_3 : Form
    {
        public Kontc_3()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Kontc_3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.pokupateli". При необходимости она может быть перемещена или удалена.
            this.pokupateliTableAdapter.Fill(this.kontc_3DataSet.pokupateli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.postavshiki". При необходимости она может быть перемещена или удалена.
            this.postavshikiTableAdapter.Fill(this.kontc_3DataSet.postavshiki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.productProizvoditeli". При необходимости она может быть перемещена или удалена.
            this.productProizvoditeliTableAdapter.Fill(this.kontc_3DataSet.productProizvoditeli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.zakupki". При необходимости она может быть перемещена или удалена.
            this.zakupkiTableAdapter.Fill(this.kontc_3DataSet.zakupki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.prodazhi". При необходимости она может быть перемещена или удалена.
            this.prodazhiTableAdapter.Fill(this.kontc_3DataSet.prodazhi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.kontc_3DataSet.products);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.prodazhiTableAdapter.FillBy(this.kontc_3DataSet.prodazhi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            productsTableAdapter.Update(kontc_3DataSet);
            prodazhiTableAdapter.Update(kontc_3DataSet);
            zakupkiTableAdapter.Update(kontc_3DataSet);
            productProizvoditeliTableAdapter.Update(kontc_3DataSet);
            //pokupateliTableAdapter.Update(kontc_3DataSet);
            //postavshikiTableAdapter.Update(kontc_3DataSet);
            Application.Exit();
        }

        private void grp_productsSearch_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmAddProduct = new addProduct();
            frmAddProduct.ShowDialog();
        }

       

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            /* int id_product = 0;*/
            productsTableAdapter.Fill(kontc_3DataSet.products);
            kontc_3DataSet.AcceptChanges();
            productsTableAdapter.DeleteProduct(Convert.ToString(cmbBoxProductName.SelectedValue));
                /*(Convert.ToString(dataGridView1.SelectedRows[0].Cells[1]));*/

            /*int delet = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(delet);*/
            productsTableAdapter.Fill(kontc_3DataSet.products);
            kontc_3DataSet.AcceptChanges();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.productsBindingSource.EndEdit();
                this.productsTableAdapter.Update(this.kontc_3DataSet.products);
                MessageBox.Show("Данные обновлены");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка обновления");
            }
        }
        private void btnAddZakupka_Click(object sender, EventArgs e)
        {
            Form frmAddZakupka = new addZakupka();
            frmAddZakupka.ShowDialog();
        }

        private void btnUpdateZakupka_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.zakupkiBindingSource.EndEdit();
                this.zakupkiTableAdapter.Update(this.kontc_3DataSet.zakupki);
                MessageBox.Show("Данные обновлены");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка обновления");
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

