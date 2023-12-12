using System;
using System.Collections.Generic;
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
        public Studio(int id, string nama, int kapasitas, JenisStudio j, Cinema c, int hargaWeekday, int hargaWeekend)
        {
            this.ID = id;
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

                Studio s = new Studio(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(),
                    int.Parse(hasil.GetValue(2).ToString()), j, c, int.Parse(hasil.GetValue(5).ToString()),
                    int.Parse(hasil.GetValue(6).ToString()));
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

        #endregion

    }
}
