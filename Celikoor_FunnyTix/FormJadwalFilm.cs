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
    public partial class FormJadwalFilm : Form
    {
        public FormJadwalFilm()
        {
            InitializeComponent();
        }

        List<SesiFilm> listFilm;
        private void FormJadwalFilm_Load_1(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.Owner;
        }
    }
}
