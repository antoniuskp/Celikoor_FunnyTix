using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public class Studio
    {
        #region PROPERTIES
        public int ID { get; set; }
        public string Nama { get; set; }
        public int Kapasitas { get; set; }
        public JenisStudio JenisStudio { get; set; }
        public Cinema Cinema { get; set; }
        public int HargaWeekday { get; set; }
        public int HargaWeekend { get; set; }
        #endregion

        #region CONSTRUCTORS
        public Studio(string nama, int kapasitas, JenisStudio j, Cinema c, int hargaWeekday, int hargaWeekend)
        {
            this.ID = 0;
            this.Nama = nama;
            this.Kapasitas = kapasitas;
            this.JenisStudio = j;
            this.Cinema = c;
            this.HargaWeekday = hargaWeekday;
            this.HargaWeekend = hargaWeekend;
        }

        public Studio()
        {
            this.ID = 0;
            this.Nama = "";
            this.Kapasitas = 100;
            this.JenisStudio = new JenisStudio();
            this.Cinema = new Cinema();
            this.HargaWeekday = 50000;
            this.HargaWeekend = 100000;
        }
        #endregion

        #region METHODS

        #region baca data
        //public static List<Studio> BacaSesiFilm(Film f)
        //{
        //    string query = $"SELECT DISTINCT s.* FROM sesi_films sf " +
        //        $"inner join film_studio fs on sf.studios_id = fs.studios_id " +
        //        $"inner join studios s on s.id = fs.studios_id WHERE sf.films_id = '{f.Id}';";

        //    MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

        //    List<Studio> listData = new List<Studio>();
        //    while (hasil.Read() == true)
        //    {
        //        Studio s = Studio.BacaData("id", hasil.GetValue(0).ToString())[0];
        //        listData.Add(s);
        //    }
        //    return listData;
        //}

        public static List<Studio>BacaStudio(Cinema c, JenisStudio js, Film f)
        {
            //ini perlu diganti
            string query = "";
            if (f == null)
            {
                query = $"SELECT * FROM studios WHERE jenis_studios_id = '{js.Id}' AND cinemas_id ='{c.ID}';";
            }
            else
            {
                query = $"SELECT DISTINCT fs.* FROM studios s INNER JOIN film_studio fs on s.id = fs.studios_id " +
                    $"WHERE s.jenis_studios_id = '{js.Id}' AND s.cinemas_id = '{c.ID}'  AND fs.films_id = '{f.Id}';";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            List<Studio> listData = new List<Studio>();
            while (hasil.Read() == true)
            {
                Studio s = Studio.BacaData("id", hasil.GetValue(0).ToString())[0];
                listData.Add(s);
            }
            return listData;
        }

        public static List<Studio> CariStudio(Cinema c, JenisStudio js, Film f, JadwalFilm jf)
        {
            //ini perlu diganti
            string query = $"SELECT DISTINCT s.* FROM studios s INNER JOIN film_studio fs on fs.studios_id = s.id INNER JOIN sesi_films sf on sf.studios_id = fs.studios_id " +
                $"WHERE fs.films_id  = '{f.Id}' AND s.jenis_studios_id = '{js.Id}' AND s.cinemas_id = '{c.ID}' AND sf.jadwal_film_id = '{jf.Id}'; ";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            List<Studio> listData = new List<Studio>();
            while (hasil.Read() == true)
            {
                Studio s = new Studio();
                s.ID = int.Parse(hasil.GetValue(0).ToString());
                s.Nama = hasil.GetValue(1).ToString();
                s.Kapasitas = int.Parse(hasil.GetValue(2).ToString());
                s.JenisStudio = JenisStudio.BacaData("id", hasil.GetValue(3).ToString())[0];
                s.Cinema = Cinema.BacaData("id", hasil.GetValue(4).ToString())[0];
                s.HargaWeekday = int.Parse(hasil.GetValue(5).ToString());
                s.HargaWeekend = int.Parse(hasil.GetValue(6).ToString());
                listData.Add(s);
            }
            return listData;
        }


        public static List<Studio> BacaStudio(JadwalFilm jf, Film f)
        {
            string query = $"SELECT * FROM sesi_films WHERE films_id = '{f.Id}' AND jadwal_film_id = '{jf.Id}';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            List<Studio> listData = new List<Studio>();
            while(hasil.Read() == true)
            {
                Studio s = Studio.BacaData("id", hasil.GetValue(1).ToString())[0];
                listData.Add(s);
            }
            return listData;
        }
        public static List<Studio> FilterStudio (string filter = "", string value = "")
        {
            //ini perlu diganti
            string query= $"SELECT * FROM studios s WHERE {filter} like '%{value}%';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<Studio> listJadwalFilm = new List<Studio>();

            while (hasil.Read() == true)
            {
                Studio tampung = new Studio();
                tampung.ID = int.Parse(hasil.GetValue(0).ToString());
                tampung.Nama = hasil.GetValue(1).ToString();
                tampung.Kapasitas = int.Parse(hasil.GetValue(2).ToString());
                tampung.HargaWeekday = int.Parse(hasil.GetValue(5).ToString());
                tampung.HargaWeekend = int.Parse(hasil.GetValue(6).ToString());

                List<JenisStudio> listJenisStudio = JenisStudio.BacaData("Id", hasil.GetValue(3).ToString());
                tampung.JenisStudio = listJenisStudio[0];

                List<Cinema> listCinema = Cinema.BacaData("ID", hasil.GetValue(4).ToString());
                tampung.Cinema = listCinema[0];

                listJadwalFilm.Add(tampung);
            }
            return listJadwalFilm;

            }
        public static List<Studio> BacaData(string filter = "", string value = "")
        {
            //ini perlu diganti
            string query = "";
            if (filter == "")
            {
                query = $"SELECT * FROM studios;";
            }
            else
            {
                query = $"SELECT * FROM studios WHERE {filter} = '{value}';";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<Studio> listJadwalFilm = new List<Studio>();

            while (hasil.Read() == true)
            {
                Studio tampung = new Studio();
                tampung.ID = int.Parse(hasil.GetValue(0).ToString());
                tampung.Nama = hasil.GetValue(1).ToString();
                tampung.Kapasitas = int.Parse(hasil.GetValue(2).ToString());
                tampung.HargaWeekday = int.Parse(hasil.GetValue(5).ToString());
                tampung.HargaWeekend = int.Parse(hasil.GetValue(6).ToString());

                List<JenisStudio> listJenisStudio = JenisStudio.BacaData("Id", hasil.GetValue(3).ToString());
                tampung.JenisStudio = listJenisStudio[0];

                List<Cinema> listCinema = Cinema.BacaData("ID", hasil.GetValue(4).ToString());
                tampung.Cinema = listCinema[0]; 

                listJadwalFilm.Add(tampung);    
                
            }
            return listJadwalFilm;
        }
        #endregion

        #region tambah data
        public static void TambahData(Studio s)
        {
            string query = $"INSERT INTO studios (nama, kapasitas, jenis_studios_id, cinemas_id, harga_weekday, harga_weekend) " +
                $"values ('{s.Nama}', '{s.Kapasitas}', '{s.JenisStudio.Id}', '{s.Cinema.ID}', '{s.HargaWeekday}', '{s.HargaWeekend}');";

             Koneksi.JalankanPerintahNonQuery(query);
        }
        #endregion

        #region hapus data
        public static void HapusData(Studio s)
        {
            string query = $"DELETE FROM studios where id = {s.ID};";

            Koneksi.JalankanPerintahNonQuery(query);
        }
        #endregion

        #region ubah data
        public static void UbahData(Studio s)
        {
            string query = $"UPDATE studios set nama = '{s.Nama}', kapasitas = '{s.Kapasitas}', jenis_studios_id = '{s.JenisStudio.Id}', cinemas_id = '{s.Cinema.ID}', harga_weekday = '{s.HargaWeekday}', harga_weekend = '{s.HargaWeekend}' where id = '{s.ID}';";

            Koneksi.JalankanPerintahNonQuery(query);
        }
        #endregion

        public override string ToString()
        {
            return this.Nama;
        }
        #endregion

    }
}
