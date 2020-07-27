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
    public partial class addPostavshik : Form
    {
        public addPostavshik()
        {
            InitializeComponent();
        }

        private void postavshikiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postavshikiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kontc_3DataSet);

        }

        private void addPostavshik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.postavshiki". При необходимости она может быть перемещена или удалена.
            this.postavshikiTableAdapter.Fill(this.kontc_3DataSet.postavshiki);

        }

        private void btnCreatePostavshik_Click(object sender, EventArgs e)
        {
            postavshikiTableAdapter.Fill(kontc_3DataSet.postavshiki);
            kontc_3DataSet.AcceptChanges();

            postavshikiTableAdapter.InsertPostavshik(Convert.ToString(txbNamePostavshik.Text), Convert.ToString(txbPhonePostavshik.Text),
            Convert.ToString(txbEmailPostavshik.Text));

            MessageBox.Show("Данные о новом поставщике успешно внесены в базу данных", "Внесение нового поставщика в базу данных", MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);

            txbNamePostavshik.Clear();
            txbPhonePostavshik.Clear();
            txbEmailPostavshik.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
