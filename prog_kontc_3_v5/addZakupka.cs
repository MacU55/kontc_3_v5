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
            zakupkiTableAdapter.Fill(kontc_3DataSet.zakupki);
        }

        private void addZakupka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.zakupki". При необходимости она может быть перемещена или удалена.
            this.zakupkiTableAdapter.Fill(this.kontc_3DataSet.zakupki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.postavshiki". При необходимости она может быть перемещена или удалена.
            this.postavshikiTableAdapter.Fill(this.kontc_3DataSet.postavshiki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.kontc_3DataSet.products);

        }

        private void btnCreateZakupka_Click(object sender, EventArgs e)
        {
            zakupkiTableAdapter.Fill(kontc_3DataSet.zakupki);
            kontc_3DataSet.AcceptChanges();

           
            zakupkiTableAdapter.InsertZakupka(Convert.ToInt32(cmbIdProduct.SelectedValue), Convert.ToInt32(cmbIdPostavshik.SelectedValue),
            Convert.ToString(dateZakupka.Value), Convert.ToDecimal(numPriceProduct.Value), Convert.ToInt32(numericKolvoProduct.Value),
            Convert.ToDecimal(numericPriceFactor.Value));

            MessageBox.Show("Закупка успешно создана и внесена в базу данных", "Создание новой закупки", MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);

            cmbIdProduct.SelectedIndex = 0;
            cmbIdPostavshik.SelectedIndex = 0;
            numPriceProduct.Value = 0;
            numericPriceFactor.Value = 0;
        }
    }
}
