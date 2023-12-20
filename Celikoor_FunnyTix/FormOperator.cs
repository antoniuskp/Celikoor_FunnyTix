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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            FormUtama frmUtama = (FormUtama)this.Owner;
            textBoxID.Text = $"{Auth.GetPegawai().ID}";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string noInv = (textBoxNoTiket.Text).Substring(0, 3);
            Tiket.UpdateKehadiran(noInv);
        }

        private void textBoxNoTiket_TextChanged(object sender, EventArgs e)
        {
            string noInv = textBoxNoTiket.Text.Substring(0, 3);
            listTiket = Tiket.BacaData("invoices_id", noInv);
            if(listTiket[2].ToString() == "true")
            {
                textBoxStatus.Text = "Checked in";
                buttonUpdate.Enabled = false;
            }
            else
            {
                textBoxStatus.Text = "Not checked in";
            }

            string harga = listTiket[4].ToString();
            textBoxNoKursi.Text = listTiket[0].ToString();

            //Tiket t = Tiket.BacaData("invoices_id", noTiket)[5];

        }

        private void textBoxNoTiket_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
