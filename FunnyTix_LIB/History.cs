using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyTix_LIB
{
    public class History
    {
        private string status;
        private DateTime tanggal;
        private string noKursi;
        private int harga;
        private string judul;


        public History()
        {
            this.Status = "";
            this.Tanggal = DateTime.Now;
            this.NoKursi = "";
            this.Harga = 0;
            this.Judul = "";
        }
        public History(string status, DateTime tanggal, string noKursi, int harga, string judul)
        {
            this.Status = status;
            this.Tanggal = tanggal;
            this.NoKursi = noKursi;
            this.Harga = harga;
            this.Judul = judul;
        }

        public string Status { get => status; set => status = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string NoKursi { get => noKursi; set => noKursi = value; }
        public int Harga { get => harga; set => harga = value; }
        public string Judul { get => judul; set => judul = value; }

        #region
        public static List<History> BacaHistory(int value)
        {
            string query = $"SELECT DISTINCT i.status, i.tanggal, t.nomor_kursi, t.harga, f.judul FROM konsumens k INNER JOIN " +
                $"invoices i on k.id = i.konsumens_id INNER JOIN tikets t on t.invoices_id = i.id " +
                $"INNER JOIN sesi_films sf on t.films_id = sf.films_id " +
                $"INNER JOIN film_studio fs ON sf.films_id = fs.films_id " +
                $"INNER JOIN films f ON f.id = fs.films_id WHERE k.id = {value};";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            List<History> listHistory = new List<History>();
            while (hasil.Read() == true)
            {
                History history = new History();
                history.Status = hasil.GetValue(0).ToString();
                history.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                history.NoKursi = hasil.GetValue(2).ToString();
                history.Harga = int.Parse(hasil.GetValue(3).ToString());    
                history.Judul = hasil.GetValue(4).ToString();

                listHistory.Add(history);
            }
            return listHistory; 
        }
        #endregion
    }
}
