using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public class Tiket
    {        
        #region PROPERTIES
        private string NoKursi { get; set; }
        private Invoice IdInvoice { get; set; }
        private bool Status { get; set; }
        private Pegawai Operators { get; set; }
        private double Harga { get; set; }
        private Studio Studio { get; set; }
        private Film Film { get; set; }
        private JadwalFilm JadwalFilm {get; set;}
        #endregion

        #region CONSTRUCTORS
        public Tiket(Invoice idInvoice, bool status, Pegawai operators, double harga, Studio studio, Film film, JadwalFilm jadwalFilm)
        {
            NoKursi = "";
            IdInvoice = idInvoice;
            Status = status;
            Operators = operators;
            Harga = harga;
            Studio = studio;
            Film = film;
            JadwalFilm = jadwalFilm;
        }

        public Tiket()
        {
            this.NoKursi = "";
            this.IdInvoice = new Invoice();
            this.Status = false;
            this.Operators = new Pegawai();
            this.Harga = 0.0;
            this.Studio = new Studio();
            this.Film = new Film();
            this.JadwalFilm = new JadwalFilm();

        }
        #endregion

        #region METHODS
        public static List<string> CariNomorKursi(int fid, DateTime tgl, string cinema, string studio, string jamPemutaran)
        {
            List<string> nomorKursi = new List<string>();

            string cmd = $"select distinct t.nomor_kursi " +
                $"from jadwal_films as jf " +
                $"inner join sesi_films as sf on jf.id = sf.jadwal_film_id " +
                $"inner join film_studio as fs on sf.films_id = fs.films_id " +
                $"inner join films as f on fs.films_id = f.id " +
                $"inner join studios as s on fs.studios_id = s.id " +
                $"inner join cinemas as c on s.cinemas_id = c.id " +
                $"inner join tikets as t on t.jadwal_film_id = sf.jadwal_film_id and t.studios_id = sf.studios_id and t.films_id = sf.films_id " +
                $"where f.id = '{fid}' and jf.tanggal = '{tgl.ToString("yyyy-MM-dd")}' and c.nama_cabang = '{cinema}' and s.nama = '{studio}' and jf.jam_pemutaran = '{jamPemutaran}';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(cmd);

            while (hasil.Read() == true)
            {
                nomorKursi.Add(hasil.GetValue(0).ToString());
            }

            return nomorKursi;
        }

        public static List<Tiket> BacaData(string filter = "", string value = "")
        {
            string query = $"";
            if(filter == "")
            {
                query = $"SELECT * FROM tikets;";
            }
            else
            {
                query = $"SELECT * FROM tikets where {filter} = '{value}'";
            }

            List<Tiket> listTiket = new List<Tiket>();
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            while(hasil.Read()== true)
            {
                Tiket t = new Tiket();
                t.NoKursi = hasil.GetValue(0).ToString();
                Invoice i = new Invoice();
                i.Id= int.Parse(hasil.GetValue(1).ToString());
                t.IdInvoice = i;
                t.Status = false;

                if (hasil.GetValue(2).ToString()== "1")
                {
                    t.Status = true;
                }

                Pegawai p = new Pegawai();
                p.ID = int.Parse(hasil.GetValue(3).ToString());
                t.Operators = p;

                t.Harga = Double.Parse(hasil.GetValue(4).ToString());

                JadwalFilm j = new JadwalFilm();
                j.ID = int.Parse(hasil.GetValue(5).ToString());
                t.JadwalFilm = j;

                Studio s = new Studio();
                s.ID = int.Parse(hasil.GetValue(6).ToString());
                t.Studio = s;

                Film f = new Film();
                f.Id = int.Parse(hasil.GetValue(7).ToString());
                t.Film = f;

                listTiket.Add(t);
            }

            return listTiket;
        }

        public static void TambahData(Tiket t)
        {
            int res = 0;
            if(t.Status == true)
            {
                res = 1;
            }
            string cmd = $"INSERT INTO tikets (invoices_id, nomor_kursi, status_hadir, operator_id, harga, jadwal_film_id, studios_id, films_id) " +
                $"values ({t.IdInvoice}, '{t.NoKursi}', '{res}', '{t.Operators.ID}', '{t.Harga}', '{t.JadwalFilm.ID}', '{t.Studio.ID}', '{t.Film.Id}';";
            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        public static void UpdateKehadiran(string noInvoice)
        {
            string cmd = $"UPDATE tikets set status_hadir = 1 WHERE invoices_id = '{noInvoice}';";
            Koneksi.JalankanPerintahNonQuery(cmd);
        }

        public static void DeleteData(Tiket t)
        {
            string cmd = $"DELETE FROM tikets WHERE nomor_kursi = '{t.NoKursi}';";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        #endregion
    }
}
