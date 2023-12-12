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
    public partial class FormMasterPegawai : Form
    {
        public FormMasterPegawai()
        {
            InitializeComponent();
        }

        private void FormMasterPegawai_Load(object sender, EventArgs e)
        {
            try
            {
                List<Pegawai> listPegawai = Pegawai.BacaData();
                
                dataGridViewHasil.DataSource = listPegawai;

                //comboBox.DataSource = listPegawai;
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                dataGridViewHasil.DataSource = listPegawai;

            }
            catch(Exception ex)
            {

            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {

        }
    }
}
