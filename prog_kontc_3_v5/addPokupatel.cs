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
    public partial class addPokupatel : Form
    {
        public addPokupatel()
        {
            InitializeComponent();
        }

        private void addPokupatel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.pokupateli". При необходимости она может быть перемещена или удалена.
            this.pokupateliTableAdapter.Fill(this.kontc_3DataSet.pokupateli);

        }

        private void pokupateliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pokupateliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kontc_3DataSet);

        }

        private void btnCreatePokupatel_Click(object sender, EventArgs e)
        {
            pokupateliTableAdapter.Fill(kontc_3DataSet.pokupateli);
            kontc_3DataSet.AcceptChanges();

            pokupateliTableAdapter.InsertPokupatel(Convert.ToString(txbNamePokupatel.Text), Convert.ToString(txbPhonePokupatel.Text),
            Convert.ToString(txbEmailPokupatel.Text));

            MessageBox.Show("Данные о новом поставщике успешно внесены в базу данных", "Внесение нового поставщика в базу данных", MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);

            txbNamePokupatel.Clear();
            txbPhonePokupatel.Clear();
            txbEmailPokupatel.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
