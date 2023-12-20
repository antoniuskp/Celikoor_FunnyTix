using System;
using System.Collections.Generic;
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
