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
    public partial class FormUpdateInvoice : Form
    {
        public FormUpdateInvoice()
        {
            InitializeComponent();
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            FormUtama frmUtama = (FormUtama)this.Owner;
        }

        private void textBoxNoInv_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
