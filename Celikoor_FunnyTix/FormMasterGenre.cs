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
    public partial class FormMasterGenre : Form
    {
        public FormMasterGenre()
        {
            InitializeComponent();
        }

        private void FormMasterGenre_Load(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;

            List<Genre> listGenre = Genre.BacaData(); 

            dataGridViewHasil.DataSource = listGenre;
        }
    }
}
