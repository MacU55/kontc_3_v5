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
    public partial class addProizvoditel : Form
    {
        public addProizvoditel()
        {
            InitializeComponent();
        }

        private void btnAddProizvoditel_Click(object sender, EventArgs e)
        {
            productProizvoditeliTableAdapter.Fill(kontc_3DataSet.productProizvoditeli);
            kontc_3DataSet.AcceptChanges();

            productProizvoditeliTableAdapter.InsertProizvoditel(Convert.ToString(txbNameProizvodirel.Text));

            MessageBox.Show("Данные о новом производителе успешно внесены в базу данных", "Внесение нового производителя в базу данных", MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);

            txbNameProizvodirel.Clear();
        }

        private void productProizvoditeliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productProizvoditeliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kontc_3DataSet);

        }

        private void addProizvoditel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.productProizvoditeli". При необходимости она может быть перемещена или удалена.
            this.productProizvoditeliTableAdapter.Fill(this.kontc_3DataSet.productProizvoditeli);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
