using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunnyTix_LIB;

namespace Celikoor_FunnyTix
{
    public partial class FormMasterKonsumen : Form
    {
        public FormMasterKonsumen()
        {
            InitializeComponent();
        }
        List<Konsumen> listKonsumen;
        private void FormMasterKonsumen_Load(object sender, EventArgs e)
        {
            //FormPegawai frmPegawai = (FormPegawai)this.Owner;

            listKonsumen = Konsumen.BacaData();

            dataGridViewHasil.DataSource = listKonsumen;
            
        }
    }
}
