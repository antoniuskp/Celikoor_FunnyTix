using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace FunnyTix_LIB
{
    public class JenisStudio
    {
        #region DATA MEMBERS
        private int id;
        private string nama;
        private string deskripsi;


        #endregion

        #region CONSTRUCTORS
        public JenisStudio(string nama, string deskripsi)
        {
            this.Id = 0;
            this.Nama = nama;
            this.Deskripsi = deskripsi;
        }
        public JenisStudio()
        {
            this.Id = 0;
            this.Nama = "";
            this.Deskripsi = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        #endregion

        #region METHODS
        public static List<JenisStudio> BacaJenisStudio(Cinema c)
        {
            string query = $"SELECT DISTINCT js.* FROM jenis_studios js LEFT JOIN studios s on s.jenis_studios_id = js.id LEFT JOIN cinemas c ON c.id = s.cinemas_id WHERE c.id = '{c.ID}';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            List<JenisStudio> listJenisStudio = new List<JenisStudio>();
            while (hasil.Read() == true)
            {
                JenisStudio j = new JenisStudio();
                j.Id = int.Parse(hasil.GetValue(0).ToString());
                j.Nama = hasil.GetValue(1).ToString();
                j.Deskripsi = hasil.GetValue(2).ToString();
                listJenisStudio.Add(j);
            }
            return listJenisStudio;
        }
        public static List<JenisStudio> BacaJenisStudioFilm(Film f)
        {
            string query = $"SELECT DISTINCT js.* FROM jenis_studios js " +
                $"INNER JOIN studios s on js.id = s.jenis_studios_id " +
                $"INNER JOIN film_studio fs on s.id = fs.studios_id WHERE fs.films_id = '{f.Id}';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            List<JenisStudio> listJenisStudio = new List<JenisStudio>();
            while (hasil.Read() == true)
            {
                JenisStudio j = new JenisStudio();
                j.Id = int.Parse(hasil.GetValue(0).ToString());
                j.Nama = hasil.GetValue(1).ToString();
                j.Deskripsi = hasil.GetValue(2).ToString();
                listJenisStudio.Add(j);
            }
            return listJenisStudio;
        }

        public static JenisStudio CariJenisStudio(Studio s)
        {
            string query = $"SELECT js.* FROM jenis_studios js INNER JOIN studios s on s.jenis_studios_id = js.id WHERE s.id = '{s.ID}';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            if (hasil.Read() == true)
            {
                JenisStudio js = new JenisStudio();
                js.Id = int.Parse(hasil.GetValue(0).ToString());
                js.Nama = hasil.GetValue(1).ToString();
                js.Deskripsi = hasil.GetValue(2).ToString();
                return js;
            }
            else
            {
                return null;
            }
        }
        public static List<JenisStudio> CariJenisStudio(string filter = "", string value = "")
        {
            string query = $"SELECT * FROM jenis_studios where {filter} like '%{value}%';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<JenisStudio> listJenisStudio = new List<JenisStudio>();

            while (hasil.Read() == true)
            {
                JenisStudio jS = new JenisStudio(
                    hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString());
                jS.Id = int.Parse(hasil.GetValue(0).ToString());
                listJenisStudio.Add(jS);
            }
            return listJenisStudio;
        }

        public static List<JenisStudio> BacaData(string filter = "", string value = "")
        {
            string query = "SELECT * FROM jenis_studios;";
            if(value!= "")
            {
                int kode = int.Parse(value);
                query = $"SELECT * FROM jenis_studios where {filter} = '{kode}';";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<JenisStudio> listJenisStudio = new List<JenisStudio>();
            
            while(hasil.Read() == true)
            {
                JenisStudio jS = new JenisStudio(
                    hasil.GetValue(1).ToString(), 
                    hasil.GetValue(2).ToString());
                jS.Id = int.Parse(hasil.GetValue(0).ToString());
                listJenisStudio.Add(jS);
            }
            return listJenisStudio;
        }

        public static void TambahData(JenisStudio js)
        {
            string cmd = $"INSERT INTO jenis_studios (nama, deskripsi) values ('{js.Nama}', '{js.Deskripsi}');";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }

        public static void DeleteData(string kodeHapus)
        {
            string cmd = $"DELETE FROM jenis_studios WHERE id = '{kodeHapus}';";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }

        public override string ToString()
        {
            return Nama;
        }
        #endregion


    }
}
