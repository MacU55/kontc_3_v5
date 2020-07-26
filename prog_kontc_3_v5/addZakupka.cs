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
    public partial class addZakupka : Form
    {
        public addZakupka()
        {
            InitializeComponent();
        }

        private void zakupkiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zakupkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kontc_3DataSet);

        }

        private void addZakupka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.postavshiki". При необходимости она может быть перемещена или удалена.
            this.postavshikiTableAdapter.Fill(this.kontc_3DataSet.postavshiki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.kontc_3DataSet.products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.zakupki". При необходимости она может быть перемещена или удалена.
            this.zakupkiTableAdapter.Fill(this.kontc_3DataSet.zakupki);

        }

        private void btnCreateZakupka_Click(object sender, EventArgs e)
        {
            zakupkiTableAdapter.Fill(kontc_3DataSet.zakupki);
            kontc_3DataSet.AcceptChanges();

            zakupkiTableAdapter.InsertZakupka(Convert.ToInt32(cmbIdProduct.SelectedValue), Convert.ToInt32(cmbIdPostavshik.SelectedValue),
            Convert.ToString(dateTimeZakupka.Value), Convert.ToDecimal(numPriceZakupka.Value), 
            Convert.ToInt32(numKolvoZakupka.Value), Convert.ToDecimal(numPriceFactor.Value));

            MessageBox.Show("Закупка успешно внесена в базу данных", "Внесение новой закупки в базу", MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);

            cmbIdProduct.SelectedValue = 0;
            cmbIdPostavshik.SelectedValue = 0;
            numPriceZakupka.Value = 0;
            numKolvoZakupka.Value = 0;
            numPriceFactor.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
