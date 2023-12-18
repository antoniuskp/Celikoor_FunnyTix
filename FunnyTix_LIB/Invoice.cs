using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace FunnyTix_LIB
{
    public class Invoice
    {
        #region DATA MEMBERS
        private int id;
        private DateTime tanggal;
        private double grandTotal;
        private double diskonNominal;
        private Konsumen konsumen;
        private Pegawai kasir;
        private string status;
        #endregion

        #region CONSTRUCTORS
        public Invoice(DateTime tanggal, double grandTotal, double diskonNominal, Konsumen konsumen, Pegawai kasir, string status)
        {
            Id = 0;
            Tanggal = tanggal;
            GrandTotal = grandTotal;
            DiskonNominal = diskonNominal;
            Konsumen = konsumen;
            Kasir = kasir;
            Status = status;
        }
        public Invoice()
        {
            Id = 0;
            Tanggal = DateTime.Now;
            GrandTotal = 0;
            DiskonNominal = 0;
            Konsumen = new Konsumen();
            Kasir = new Pegawai();
            Status = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public double GrandTotal { get => grandTotal; set => grandTotal = value; }
        public double DiskonNominal { get => diskonNominal; set => diskonNominal = value; }
        public Konsumen Konsumen { get => konsumen; set => konsumen = value; }
        public Pegawai Kasir { get => kasir; set => kasir = value; }
        public string Status { get => status; set => status = value; }
        #endregion

        #region METHODS
        public static List<Invoice> BacaData(string value = "")
        {
            string query = "SELECT * FROM invoices;";
            if (value != "")
            {
                int kode = int.Parse(value);
                query = $"SELECT * FROM invoices where id = {kode};";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<Invoice> listInvoice = new List<Invoice>();

            while (hasil.Read() == true)
            {
                Invoice invoice = new Invoice(
                    DateTime.Parse(hasil.GetValue(1).ToString()),
                    double.Parse(hasil.GetValue(2).ToString()),
                    double.Parse(hasil.GetValue(3).ToString()),
                    Konsumen.BacaData("id", hasil.GetValue(4).ToString())[0],
                    Pegawai.BacaData("id", hasil.GetValue(5).ToString())[0],
                    hasil.GetValue(6).ToString());

                invoice.Id = int.Parse(hasil.GetValue(0).ToString());
                listInvoice.Add(invoice);
            }
            return listInvoice;
        }

        public static void TambahData(Invoice invoice)
        {
            string cmd = $"INSERT INTO invoices (tanggal, grand_total, diskon_nominal, konsumen_id, kasir_id, status) values ('{invoice.Id}', '{invoice.Tanggal}','{invoice.GrandTotal}','{invoice.DiskonNominal}','{invoice.Konsumen.ID}','{invoice.Kasir.ID}','{invoice.Status}');";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }

        /*public static void DeleteData(Invoice invoice)
        {
            string cmd = $"UPDATE invoices set tanggal = '{invoice.Tanggal}', grand_total = '{invoice.GrandTotal}', diskon_nominal = '{invoice.DiskonNominal}', konsumen_id = '{invoice.Konsumen.ID}', kasir_id = '{invoice.Kasir.ID}', status = '{invoice.Status}';";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }*/

        public override string ToString()
        {
            return Konsumen.ID.ToString();
        }
        #endregion

    }
}

