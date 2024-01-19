using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyTix_LIB
{
    public class InvoiceMenu
    {
        private int id;
        private DateTime tanggal;
        private double grand_total;
        private Konsumen konsumen;
        private Pegawai kasir;
        private string status;

        public InvoiceMenu()
        {
            this.Id = 0;
            this.Tanggal = DateTime.Now;
            this.Grand_total = 0;
            this.Konsumen = new Konsumen();
            this.Kasir = new Pegawai();
            this.Status = "PENDING";
        }
        public InvoiceMenu(int id, DateTime tanggal, double grand_total, Konsumen konsumen, Pegawai kasir, string status)
        {
            this.Id = id;
            this.Tanggal = tanggal;
            this.Grand_total = grand_total;
            this.Konsumen = konsumen;
            this.Kasir = kasir;
            this.Status = status;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public double Grand_total { get => grand_total; set => grand_total = value; }
        public Konsumen Konsumen { get => konsumen; set => konsumen = value; }
        public Pegawai Kasir { get => kasir; set => kasir = value; }
        public string Status { get => status; set => status = value; }

        #region METHOD
        public static List<InvoiceMenu> BacaData(string filter = "", string value = "", Konsumen k = null)
        {
            string query = "SELECT * FROM invoices_makanans;";
            if (value != "" && k == null)
            {
                query = $"SELECT * FROM invoices_makanans where {filter} like '%{value}%';";
            }
            else if (filter == "tanggal" && value != "" && k != null)
            {
                query = $"SELECT * FROM invoices_makanans WHERE tanggal LIKE '{value}%' AND konsumens_id = '{k.ID}';";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<InvoiceMenu> listInvoiceMenu = new List<InvoiceMenu>();

            while (hasil.Read() == true)
            {
                InvoiceMenu invoice = new InvoiceMenu();
                invoice.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                invoice.Grand_total = double.Parse(hasil.GetValue(2).ToString());
                invoice.Konsumen = Konsumen.BacaData("Id", hasil.GetValue(3).ToString())[0];
                invoice.Kasir = Pegawai.BacaData("Id", hasil.GetValue(4).ToString())[0];

                invoice.Id = int.Parse(hasil.GetValue(0).ToString());

                if(invoice.Kasir != null)
                {
                    invoice.Status = "TERBAYAR";
                }
                listInvoiceMenu.Add(invoice);
            }
            return listInvoiceMenu;
        }
        #endregion
    }
}
