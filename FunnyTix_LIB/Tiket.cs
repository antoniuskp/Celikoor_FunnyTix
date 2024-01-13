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
        #region DATA MEMBERS
        string noKursi;
        Invoice idInvoice;
        bool status;
        Pegawai operators;
        double harga;
        Studio studio;
        Film film;
        JadwalFilm jadwalFilm;
        #endregion

        #region PROPERTIES
        public string NoKursi { get => noKursi; set => noKursi = value; }
        public Invoice IdInvoice { get => idInvoice; set => idInvoice = value; }
        public bool Status { get => status; set => status = value; }
        public Pegawai Operators { get => operators; set => operators = value; }
        public double Harga { get => harga; set => harga = value; }
        public Studio Studio { get => studio; set => studio = value; }
        public Film Film { get => film; set => film = value; }
        public JadwalFilm JadwalFilm { get => jadwalFilm; set => jadwalFilm = value; }
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
        public static Studio CariStudio(int invId, string noKursi)
        {
            string query = $"SELECT DISTINCT fs.studios_id FROM tikets t INNER JOIN sesi_films sf on sf.films_id = t.films_id INNER JOIN film_studio fs on fs.films_id = t.films_id WHERE t.nomor_kursi = '{noKursi}' AND t.invoices_id = '{invId}';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            if (hasil.Read() == true)
            {
                Studio s = Studio.BacaData("id", hasil.GetValue(0).ToString())[0];
                if (s != null)
                {
                    return s;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public static Film CariFilm(int invId, string noKursi)
        {
            string query = $"SELECT DISTINCT fs.films_id FROM tikets t INNER JOIN sesi_films sf on sf.films_id = t.films_id INNER JOIN film_studio fs on fs.films_id = t.films_id WHERE t.nomor_kursi = '{noKursi}' AND t.invoices_id = '{invId}';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            
            if(hasil.Read() == true)
            {
                Film f = Film.BacaData(hasil.GetValue(0).ToString())[0];
                if(f != null)
                {
                    return f;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            } 
        }

        public static Tiket CariTiket(int invId, string noKursi)
        {
            string query = $"SELECT t.* FROM tikets t WHERE t.nomor_kursi = '{noKursi}' AND t.invoices_id = '{invId}';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            if(hasil.Read() == true)
            {
                Tiket t = new Tiket();
                t.NoKursi = hasil.GetValue(1).ToString();
                Invoice i = new Invoice();
                i.Id = int.Parse(hasil.GetValue(0).ToString());
                t.IdInvoice = i;
                t.Status = false;

                if (hasil.GetValue(2).ToString() == "1")
                {
                    t.Status = true;
                }

                Pegawai p = new Pegawai();
                p.ID = int.Parse(hasil.GetValue(3).ToString());
                t.Operators = p;

                t.Harga = Double.Parse(hasil.GetValue(4).ToString());

                JadwalFilm j = new JadwalFilm();
                j.Id = int.Parse(hasil.GetValue(5).ToString());
                t.JadwalFilm = j;

                Studio s = new Studio();
                s.ID = int.Parse(hasil.GetValue(6).ToString());
                t.Studio = s;

                Film f = new Film();
                f.Id = int.Parse(hasil.GetValue(7).ToString());
                t.Film = f;

                return t;
            }
            else
            {
                return null;
            }
        }
        public static List<string> CariNomorKursi(JadwalFilm jf, Studio s, Film f)
        {
            List<string> nomorKursi = new List<string>();

            //string cmd = $"select distinct t.nomor_kursi " +
            //    $"from jadwal_films as jf " +
            //    $"inner join sesi_films as sf on jf.id = sf.jadwal_film_id " +
            //    $"inner join film_studio as fs on sf.films_id = fs.films_id " +
            //    $"inner join films as f on fs.films_id = f.id " +
            //    $"inner join studios as s on fs.studios_id = s.id " +
            //    $"inner join cinemas as c on s.cinemas_id = c.id " +
            //    $"inner join tikets as t on t.jadwal_film_id = sf.jadwal_film_id and t.studios_id = sf.studios_id and t.films_id = sf.films_id " +
            //    $"where f.id = '{fid}' and jf.tanggal = '{tgl.ToString("yyyy-MM-dd")}' and c.nama_cabang = '{cinema}' and s.nama = '{studio}' and jf.jam_pemutaran = '{jamPemutaran}';";

            string cmd = $"SELECT t.nomor_kursi from tikets t where t.jadwal_film_id = '{jf.Id}' AND t.studios_id = '{s.ID}' AND t.films_id = '{f.Id}';";

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
                j.Id = int.Parse(hasil.GetValue(5).ToString());
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
                $"values ({t.IdInvoice}, '{t.NoKursi}', '{res}', '{t.Operators.ID}', '{t.Harga}', '{t.JadwalFilm.Id}', '{t.Studio.ID}', '{t.Film.Id}';";
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
