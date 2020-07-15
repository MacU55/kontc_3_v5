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
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kontc_3DataSet.productProizvoditeli". При необходимости она может быть перемещена или удалена.
            this.productProizvoditeliTableAdapter.Fill(this.kontc_3DataSet.productProizvoditeli);

        }






        private void button1_Click(object sender, EventArgs e)
        {
            private bool edit;
            if (!edit) return;
            var edt = new addProduct();
            edt.ShowDialog();
            productsTableAdapter1.Fill(kontc_3DataSet.products);
            kontc_3DataSet.AcceptChanges();
        }

    }
}
}
