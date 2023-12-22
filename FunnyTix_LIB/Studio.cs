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
                JenisStudio j = new JenisStudio();
                j.Id = int.Parse(hasil.GetValue(3).ToString());

                Cinema c = new Cinema();
                c.ID = int.Parse(hasil.GetValue(4).ToString());

                Studio s = new Studio(hasil.GetValue(1).ToString(),
                    int.Parse(hasil.GetValue(2).ToString()), j, c, int.Parse(hasil.GetValue(5).ToString()),
                    int.Parse(hasil.GetValue(6).ToString()));
                s.ID = int.Parse(hasil.GetValue(0).ToString());
                listJadwalFilm.Add(s);
            }
            return listJadwalFilm;
        }

        public static void TambahData(Studio s)
        {
            string query = $"INSERT INTO studios (nama, kapasitas, jenis_studios_id, cinemas_id, harga_weekday, harga_weekend) values ('{s.Nama}', {s.Kapasitas}, " +
                $"{s.JenisStudio.Id}, {s.Cinema.ID}, {s.HargaWeekday}, {s.HargaWeekend});";

             Koneksi.JalankanPerintahNonQuery(query);
        }

        public static void HapusData(Studio s)
        {
            string query = $"DELETE FROM studios where id = {s.ID};";

            Koneksi.JalankanPerintahNonQuery(query);
        }

        public static void UbahData(Studio s)
        {
            string query = $"UPDATE studios set nama = '{s.Nama}', kapasitas = {s.Kapasitas}, jenis_studios_id = {s.JenisStudio.Id}, cinemas_id = {s.Cinema.ID}, harga_weekday = {s.HargaWeekday}, harga_weekend = {s.HargaWeekend} where id = {s.ID};";

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
