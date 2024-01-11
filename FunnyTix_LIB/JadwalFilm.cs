using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public class JadwalFilm
    {
        #region data members
        private int id;
        private DateTime tanggal;
        private string jam_pemutaran;

        public JadwalFilm()
        {
            this.Id = 0;
            this.Tanggal = DateTime.Now;
            this.Jam_pemutaran = "";
        }

        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string Jam_pemutaran { get => jam_pemutaran; set => jam_pemutaran = value; }
        #endregion
        #region methods 
        public static void TambahData(JadwalFilm jf)
        {
            string cmd = $"INSERT INTO jadwal_films (tanggal, jam_pemutaran) " +
                $"values ('{jf.Tanggal.ToString("yyyy-MM-dd")}', '{jf.Jam_pemutaran}');";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }

        public static void DeleteData(JadwalFilm jf)
        {
            string cmd = $"DELETE from jadwal_films where id = {jf.Id};";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }

        public static string DefineJam(int invId, string noKursi)
        {
            string jam = "";

            string query = "select jf.jam_pemutaran from jadwal_films as jf " +
                           " inner join sesi_films as sf on sf.jadwal_film_id = jf.id " +
                           " inner join tikets as t on t.jadwal_film_id = sf.jadwal_film_id" +
                           $" where t.invoices_id = {invId} and t.nomor_kursi = '{noKursi}';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            while (hasil.Read() == true)
            {
                string sesi = hasil.GetValue(0).ToString();
                jam = SesiToJam(sesi);
            }

            return jam;
        }

        public static string SesiToJam(string sesi)
        {
            string jam = "";
            switch (sesi)
            {
                case "I":
                    jam = "12.00 - 15.00 WIB";
                    break;
                case "II":
                    jam = "15.30 - 18.30 WIB";
                    break;
                case "III":
                    jam = "19.00 - 22.00 WIB";
                    break;
                case "IV":
                    jam = "22.30 - 01.30 WIB";
                    break;
            }
            return jam;
        }

        public static List<SesiFilm> BacaFilmHari(DateTime tanggalPemutaran, string judul="")
        {
            //Ambil JadwalFilmHariIni
            List<JadwalFilm> jadwalHariIni = JadwalFilm.BacaData("tanggal", tanggalPemutaran.ToString("yyyy-MM-dd"));
            List<SesiFilm> sesiFilmHariIni = new List<SesiFilm>();
            for (int i = 0; i < jadwalHariIni.Count; i++)
            {
                string query = $"SELECT * FROM sesi_films where jadwal_film_id = '{jadwalHariIni[i].Id}';";
                MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
                while (hasil.Read() == true)
                {
                    
                    if (judul!="")
                    {
                        List<Film> listJudul = Film.BacaDataJudul(judul);

                        if (listJudul.Count == 0) {
                            return new List<SesiFilm>();
                        }
                        //return Film.BacaData(hasil.GetValue(2).ToString())[0].Id.ToString();
                        if (Film.BacaData(hasil.GetValue(2).ToString())[0].Id==Film.BacaDataJudul(judul)[0].Id)
                        {
                            SesiFilm sf = new SesiFilm();
                            sf.JadwalFilm = JadwalFilm.BacaData("id", hasil.GetValue(0).ToString())[0];
                            sf.FilmStudio.Film = Film.BacaData(hasil.GetValue(2).ToString())[0];
                            sf.FilmStudio.Studio = Studio.BacaData("id", hasil.GetValue(1).ToString())[0];
                            sesiFilmHariIni.Add(sf);
                            break;
                        }
                        else
                        {
                            SesiFilm sf = new SesiFilm();
                        sf.JadwalFilm = JadwalFilm.BacaData("id", hasil.GetValue(0).ToString())[0];
                        sf.FilmStudio.Film = Film.BacaData(hasil.GetValue(2).ToString())[0];
                        sf.FilmStudio.Studio = Studio.BacaData("id", hasil.GetValue(1).ToString())[0];
                        sesiFilmHariIni.Add(sf);
                            break;
                        }
                    }
                    else
                    {
                        SesiFilm sf = new SesiFilm();
                        sf.JadwalFilm = JadwalFilm.BacaData("id", hasil.GetValue(0).ToString())[0];
                        sf.FilmStudio.Film = Film.BacaData(hasil.GetValue(2).ToString())[0];
                        sf.FilmStudio.Studio = Studio.BacaData("id",hasil.GetValue(1).ToString())[0];
                        sesiFilmHariIni.Add(sf);
                        break;
                    }
                }
            }
            //return "";
            return sesiFilmHariIni;
        }

        public static List<JadwalFilm> BacaData(string filter = "", string value = "", string jam = "")
        {
            string query = "SELECT * FROM jadwal_films;";
            if (filter != "")
            {
                query = $"SELECT * FROM jadwal_films where {filter} = '{value}';";
            }
            if (filter == "tanggal" && jam != "")
            {
                query = $"SELECT * FROM `jadwal_films` WHERE jam_pemutaran = '{jam}' AND tanggal = '{value}';";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<JadwalFilm> listJadwalFilm = new List<JadwalFilm>();

            while (hasil.Read() == true)
            {
                var js = new JadwalFilm();
                js.Id = int.Parse(hasil.GetValue(0).ToString());
                js.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                js.Jam_pemutaran = hasil.GetValue(2).ToString();

                listJadwalFilm.Add(js);
            }
            return listJadwalFilm;
        }

        /*public override string ToString()
        {
            string data = Tanggal + " " + Jam_pemutaran;
            return data;
        }*/
        #endregion
    }
}
