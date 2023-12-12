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
    public partial class FormMasterCinema : Form
    {
        public FormMasterCinema()
        {
            InitializeComponent();
        }

        private void FormMasterCinema_Load(object sender, EventArgs e)
        {
            FormPegawai frm =(FormPegawai)this.Owner;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Cinema> listCinema = Cinema.BacaData();

            dataGridViewHasil.DataSource = listCinema;
        }
    }
}
