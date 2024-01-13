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
        public static List<Studio> BacaStudioSesiFilm(JadwalFilm jf, Film f)
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

        public static List<Studio> CariStudio(Film f)
        {
            //var data = new DataTable("Daftar Cinema");
            //data.Columns.Add("nama_cabang", typeof(string));

            //string cmd = $"select distinct c.nama_cabang " +
            //    $"from jadwal_films as jf " +
            //    $"inner  join sesi_films as sf on jf.id = sf.jadwal_film_id " +
            //    $"inner join film_studio as fs on sf.films_id = fs.films_id " +
            //    $"inner join films as f on fs.films_id = f.id " +
            //    $"inner join studios as s on fs.studios_id = s.id " +
            //    $"inner join cinemas as c on s.cinemas_id = c.id " +
            //    $"where f.id = '{fid}' and jf.tanggal = '{tgl}';";

            string cmd = $"SELECT * FROM film_studio where films_id = '{f.Id}';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(cmd);
            List<Studio> listStudio = new List<Studio>();
            while (hasil.Read() == true)
            {
                //DataRow row = data.NewRow();
                //row["nama_cabang"] = hasil.GetValue(0).ToString();
                //data.Rows.Add(row);

                Studio s = Studio.BacaData("id", hasil.GetValue(0).ToString())[0];
                listStudio.Add(s);

            }
            return listStudio;
        }

        public static List<Studio> FilterStudio (string filter = "", string value = "")
        {
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
                //JenisStudio j = new JenisStudio();
                //j.Id = int.Parse(hasil.GetValue(3).ToString());

                //Cinema c = new Cinema();
                //c.ID = int.Parse(hasil.GetValue(4).ToString());

                //Studio s = new Studio(hasil.GetValue(1).ToString(),
                //    int.Parse(hasil.GetValue(2).ToString()), j, c, int.Parse(hasil.GetValue(5).ToString()),
                //    int.Parse(hasil.GetValue(6).ToString()));
                //s.ID = int.Parse(hasil.GetValue(0).ToString());
                //listJadwalFilm.Add(s);
            }
            return listJadwalFilm;
        }

        public static void TambahData(Studio s)
        {
            string query = $"INSERT INTO studios (nama, kapasitas, jenis_studios_id, cinemas_id, harga_weekday, harga_weekend) " +
                $"values ('{s.Nama}', '{s.Kapasitas}', '{s.JenisStudio.Id}', '{s.Cinema.ID}', '{s.HargaWeekday}', '{s.HargaWeekend}');";

             Koneksi.JalankanPerintahNonQuery(query);
        }

        public static void HapusData(Studio s)
        {
            string query = $"DELETE FROM studios where id = {s.ID};";

            Koneksi.JalankanPerintahNonQuery(query);
        }

        public static void UbahData(Studio s)
        {
            string query = $"UPDATE studios set nama = '{s.Nama}', kapasitas = '{s.Kapasitas}', jenis_studios_id = '{s.JenisStudio.Id}', cinemas_id = '{s.Cinema.ID}', harga_weekday = '{s.HargaWeekday}', harga_weekend = '{s.HargaWeekend}' where id = '{s.ID}';";

            Koneksi.JalankanPerintahNonQuery(query);
        }

        public override string ToString()
        {
            return this.Nama;
        }

        public static DataTable CariJenisStudio(string nama)
        {
            var data = new DataTable("Daftar Jenis Studio");
            data.Columns.Add("jenis_studio", typeof(string));
            data.Columns.Add("harga_weekday", typeof(int));
            data.Columns.Add("harga_weekend", typeof(int));
            data.Columns.Add("kapasitas", typeof(int));



            string cmd = $"SELECT js.nama, s.harga_weekday, s.harga_weekend, s.kapasitas FROM studios s INNER JOIN jenis_studios js on s.jenis_studios_id = js.id where s.nama = '{nama}';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(cmd);

            while (hasil.Read() == true)
            {
                DataRow row = data.NewRow();
                row["jenis_studio"] = hasil.GetValue(0).ToString();
                row["harga_weekday"] = hasil.GetValue(1).ToString();
                row["harga_weekend"] = hasil.GetValue(2).ToString();
                row["kapasitas"] = hasil.GetValue(3).ToString();
                data.Rows.Add(row);
            }

            return data;
        }
        #endregion

    }
}
