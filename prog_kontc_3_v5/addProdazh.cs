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
    public partial class addProdazh : Form
    {
        public addProdazh()
        {
            InitializeComponent();
        }

        private void prodazhiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prodazhiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kontc_3DataSet);

        }

        private void addProdazh_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.pokupateli". При необходимости она может быть перемещена или удалена.
            this.pokupateliTableAdapter.Fill(this.kontc_3DataSet.pokupateli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.kontc_3DataSet.products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.prodazhi". При необходимости она может быть перемещена или удалена.
            this.prodazhiTableAdapter.Fill(this.kontc_3DataSet.prodazhi);

        }

        private void btnCreateProdazha_Click(object sender, EventArgs e)
        {
            prodazhiTableAdapter.Fill(kontc_3DataSet.prodazhi);
            kontc_3DataSet.AcceptChanges();

            prodazhiTableAdapter.InsertNewProdazha(Convert.ToInt32(cmbIdProduct.SelectedValue), Convert.ToInt32(cmbIdPokupatel.SelectedValue),
            Convert.ToString(dateTimeProdazha.Value), Convert.ToDecimal(numPriceProdazha.Value),
            Convert.ToInt32(numKolvoProdazha.Value));

            MessageBox.Show("Продажа успешно внесена в базу данных", "Внесение новой продажи в базу", MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);

            cmbIdProduct.SelectedValue = 0;
            cmbIdPokupatel.SelectedValue = 0;
            numPriceProdazha.Value = 0;
            numKolvoProdazha.Value = 0;
            
        }

        private void btnCancelProdazha_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
