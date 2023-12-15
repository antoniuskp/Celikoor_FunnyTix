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
    public partial class FormOperator : Form
    {
        public List<Tiket> listTiket;
        public FormOperator()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
                    }

        private void FormOperator_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string noInv = textBoxNoInv.Text;
            listTiket = Tiket.BacaData("invoices_id", noInv);
            foreach(Tiket t in listTiket)
            {
                
            }
        }
    }
}
