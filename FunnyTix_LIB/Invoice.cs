using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

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
        private List<Tiket> listTiket;
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
            ListTiket = new List<Tiket>();
        }
        public Invoice()
        {
            Id = 0;
            Tanggal = DateTime.Now;
            GrandTotal = 0;
            DiskonNominal = 0;
            Konsumen = new Konsumen();
            Kasir = new Pegawai();
            Status = "PENDING";
            this.ListTiket = new List<Tiket>();
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
        public List<Tiket> ListTiket { get => listTiket; set => listTiket = value; }
        #endregion

        #region METHODS
        public static int GenerateNoNota()
        {
            int notaBaru = 0;
            string cmd = $"SELECT * from invoices order by id desc limit 1;";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(cmd);

            if(hasil.Read() == true)
            {
                string noNotaAkhir = hasil.GetValue(0).ToString();

                notaBaru = int.Parse(noNotaAkhir) + 1;

            }
            return notaBaru;

        }

        public static Invoice CariInvoice(int id, string noKursi)
        {
            string query = $"SELECT i.* FROM invoices i INNER JOIN tikets t on t.invoices_id = i.id WHERE t.nomor_kursi = '{noKursi}' and i.id = '{id}';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            if (hasil.Read() == true)
            {
                Invoice i = new Invoice();
                i.id = int.Parse(hasil.GetValue(0).ToString());
                i.tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                i.GrandTotal = int.Parse(hasil.GetValue(2).ToString());
                i.DiskonNominal = int.Parse(hasil.GetValue(3).ToString());

                Konsumen k = new Konsumen();
                k.ID = int.Parse(hasil.GetValue(4).ToString());
                i.Konsumen = k;

                Pegawai p = new Pegawai();
                p.ID = int.Parse(hasil.GetValue(5).ToString());
                i.Kasir = p;

                i.Status = hasil.GetValue(6).ToString();

                return i;
            }
            else
            {
                return null;
            }
        }


        public static List<Invoice> BacaData(string filter = "", string value = "")
        {
            string query = "SELECT * FROM invoices;";
            if (value != "")
            {
                query = $"SELECT * FROM invoices where {filter} like '%{value}%';";
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

        public void TambahTiket(Tiket ticket)
        {
            Tiket t = new Tiket();
            t.NoKursi = ticket.NoKursi;
            t.Status = false;
            t.Operators = Pegawai.BacaData("id", "1")[0];
            t.Harga = ticket.Harga;
            t.JadwalFilm = ticket.JadwalFilm;
            t.Studio = ticket.Studio;
            t.Film = ticket.Film;
            this.ListTiket.Add(t);

        }
        public static void TambahData(Invoice invoice)
        {
            string cmd = $"INSERT INTO invoices (id, tanggal, grand_total, diskon_nominal, konsumens_id, status) values('{invoice.Id}','{invoice.Tanggal.ToString("yyyy-MM-dd")}', '{invoice.GrandTotal}', '{invoice.DiskonNominal}', '{invoice.Konsumen.ID}', '{invoice.Status}'); ";

            Koneksi.JalankanPerintahNonQuery(cmd);

            for(int i = 0; i < invoice.ListTiket.Count; i++)
            {
                string query = $"INSERT INTO tikets (`invoices_id`, `nomor_kursi`, `status_hadir`, `operator_id`, `harga`, `jadwal_film_id`, `studios_id`, `films_id`) " +
                    $"VALUES ('{invoice.Id}', '{invoice.ListTiket[i].NoKursi}', '{invoice.ListTiket[i].Status}', '{invoice.ListTiket[i].Operators.ID}', " +
                    $"'{invoice.ListTiket[i].Harga}', '{invoice.ListTiket[i].JadwalFilm.Id}', '{invoice.ListTiket[i].Studio.ID}', '{invoice.ListTiket[i].Film.Id}');";
                Koneksi.JalankanPerintahNonQuery(query);
            }
        }

        public static void UpdateInvoice(Invoice invoice)
        {
            string cmd = $"UPDATE invoices set status = '{invoice.Status}' where invoices.id = '{invoice.Id}';";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }

        public override string ToString()
        {
            return
            Konsumen.ID.ToString();
            //Kasir.ID.ToString();
        }
        #endregion

    }
}

