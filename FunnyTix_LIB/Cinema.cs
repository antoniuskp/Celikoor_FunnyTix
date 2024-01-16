using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public class Cinema
    {
        #region PROPERTIES
        public int ID { get; set; }
        public string NamaCabang { get; set; }
        public string Alamat { get; set; }
        public DateTime Tgl_Buka { get; set; }
        public string Kota { get; set; }
        #endregion

        #region CONSTRUCTOR
        public Cinema(string namaCabang, string alamat, DateTime tgl_Buka, string kota)
        {
            ID = 0;
            NamaCabang = namaCabang;
            Alamat = alamat;
            Tgl_Buka = tgl_Buka;
            Kota = kota;
        }
        public Cinema()
        {
            ID = 0;
            NamaCabang = "";
            Alamat = "";
            Tgl_Buka = DateTime.Now;
            Kota = "";
        }
        #endregion

        #region METHOD
        public static List<Cinema> CariCinema (JenisStudio js, Film f)
        {
            string query = $"SELECT DISTINCT cinemas_id FROM jenis_studios js INNER JOIN studios s on s.jenis_studios_id = js.id " +
                $"INNER JOIN film_studio fs on fs.studios_id = s.id WHERE js.id = '{js.Id}' AND fs.films_id = '{f.Id}';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            var listCinema = new List<Cinema>();

            while(hasil.Read() == true)
            {
                Cinema c = Cinema.BacaData("id", hasil.GetValue(0).ToString())[0];
                listCinema.Add(c);
            }
            return listCinema;
        }

        //TODO : Create
        public static void TambahData(Cinema cinema)
        {
            string cmd = $"INSERT INTO cinemas(nama_cabang, alamat, tgl_dibuka, kota) VALUES ('{cinema.NamaCabang}', '{cinema.Alamat}','{cinema.Tgl_Buka.ToString("yyyy-MM-dd")}', '{cinema.Kota}');";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }

        //TODO : Read
        public static List<Cinema> BacaData(string filter="", string val="")
        {
            string cmd = "";
            if(filter == "")
            {
                cmd = $"SELECT * FROM cinemas;";
            }
            else if(filter == "nama_cabang")
            {
                cmd = $"SELECT * FROM cinemas WHERE nama_cabang = '{val}';";
            }
            else
            {
                cmd = $"SELECT * FROM cinemas WHERE {filter} LIKE '%{val}%';";
            }
            MySqlDataReader res = Koneksi.JalankanPerintahSelect(cmd);

            var listCinema = new List<Cinema>();

            while (res.Read() == true)
            {
                Cinema c = new Cinema(
                    res.GetValue(1).ToString(),
                    res.GetValue(2).ToString(),
                    DateTime.Parse(res.GetValue(3).ToString()),
                    res.GetValue(4).ToString()
                    );
                c.ID = int.Parse(res.GetValue(0).ToString());

                listCinema.Add(c);
            }
            return listCinema;
        }

        //TODO : Delete
        public static void DeleteData(string kodeHapus)
        {
            try
            {

                string cmd = $"Select id from studios where cinemas_id = '{kodeHapus}';";
                var hasil = Koneksi.JalankanPerintahSelect(cmd);
                List<int> listStudio = new List<int>();
                while(hasil.Read())
                {
                    int id = hasil.GetInt32(0);
                    cmd = $"Delete from tikets where studios_id = '{id}'";
                    Koneksi.JalankanPerintahNonQuery(cmd);

                    cmd = $"Delete from sesi_films where studios_id = '{id}'";
                    Koneksi.JalankanPerintahNonQuery(cmd);

                    cmd = $"Delete from film_studio where studios_id = '{id}'";
                    Koneksi.JalankanPerintahNonQuery(cmd);
                }

                cmd = $"Delete from studios where cinemas_id = '{kodeHapus}';";
                Koneksi.JalankanPerintahNonQuery(cmd);

                cmd = $"DELETE FROM cinemas WHERE id = '{kodeHapus}';";
                Koneksi.JalankanPerintahNonQuery(cmd);
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public static List<Cinema> BacaCinemaJenisStudio(JenisStudio js)
        {
            string query = $"SELECT DISTINCT c.* FROM cinemas c INNER JOIN studios s on s.cinemas_id = c.id " +
                $"INNER JOIN jenis_studios js on js.id = jenis_studios_id WHERE js.id = '{js.Id}';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<Cinema> listCinema = new List<Cinema>();
            while(hasil.Read() == true)
            {
                Cinema c = new Cinema();
                c.ID = int.Parse(hasil.GetValue(0).ToString());
                c.NamaCabang = hasil.GetValue(1).ToString();
                c.Alamat = hasil.GetValue(2).ToString();
                c.Tgl_Buka = DateTime.Parse(hasil.GetValue(3).ToString());
                c.Kota = hasil.GetValue(4).ToString();
                listCinema.Add(c);
            }
            return listCinema;

        }

        public override string ToString()
        {
            return NamaCabang;
        }
        #endregion
    }
}
