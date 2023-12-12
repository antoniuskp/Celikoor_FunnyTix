using FunnyTix_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_FunnyTix
{
    public partial class FormMasterKelompok : Form
    {
        public FormMasterKelompok()
        {
            InitializeComponent();
        }

        private void FormMasterKelompok_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner.Owner.MdiParent;

            List<Kelompok> listKelompok = Kelompok.BacaData(); 

            dataGridViewHasil.DataSource = listKelompok;
        }
    }
}
