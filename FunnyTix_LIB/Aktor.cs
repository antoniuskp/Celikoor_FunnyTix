using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public class Aktor
    {
        #region PROPERTIES
        public int ID { get; set; }
        public string Nama { get; set; }
        public DateTime Tgl_Lahir { get; set; }
        public string Gender { get; set; }
        public string Negara_Asal { get; set; }
        #endregion

        #region CONSTRUCTOR
        public Aktor(string nama, DateTime tgl, string gender, string negaraAsal)
        {
            this.ID = 0;
            this.Nama = nama;
            this.Tgl_Lahir = tgl;
            this.Gender = gender;
            this.Negara_Asal = negaraAsal;
        }
        public Aktor()
        {
            this.ID = 0;
            this.Nama = "";
            this.Tgl_Lahir = DateTime.Now;
            this.Gender = "";
            this.Negara_Asal = "";
        }
        #endregion

        #region METHODS

        //Method SELECT

        public static List<Aktor> BacaAktorBelum(Film f)
        {
            string query = $"SELECT a.* FROM aktors a LEFT JOIN aktor_film af ON a.id = af.aktors_id AND af.films_id = '{f.Id}' WHERE af.aktors_id IS NULL;";

            MySqlDataReader res = Koneksi.JalankanPerintahSelect(query);

            var lstAktor = new List<Aktor>();

            while (res.Read() == true)
            {
                string idAktor = res.GetValue(0).ToString();
                Aktor a = Aktor.BacaData("id", idAktor)[0];
                lstAktor.Add(a);
            }
            return lstAktor;
        }

        public static List<Aktor> BacaData(string filter="", string val ="")
        {
            try
            {
                List<Aktor> listAktor = new List<Aktor>();
                string cmd = "";
                if (filter == String.Empty)
                {
                    cmd = $"SELECT * FROM aktors;";
                }
                else if(filter == "id")
                {
                    cmd = $"select * from aktors where {filter} = '{val}';";
                }
                else if (filter != "")
                {
                    cmd = $"select * from aktors where {filter} like '{val}%';";
                }

                MySqlDataReader res = Koneksi.JalankanPerintahSelect(cmd);
                while (res.Read() == true)
                {
                    Aktor act = new Aktor(res.GetValue(1).ToString(),
                        DateTime.Parse(res.GetValue(2).ToString()),
                        res.GetValue(3).ToString(),
                        res.GetValue(4).ToString());
                    act.ID = int.Parse(res.GetValue(0).ToString());
                    listAktor.Add(act);

                }
                return listAktor;
            }
            catch(Exception ex)
            {
                throw new Exception("Unsuccess!" + ex.Message);
            }
            
        }
        
        //Method DELETE
        public static void DeleteData(string kodeHapus)
        {
            try
            {
                string cmd = $"DELETE From aktor_film where aktors_id='{kodeHapus}';";

                Koneksi.JalankanPerintahNonQuery(cmd);

                cmd = $"DELETE FROM aktors where id = '{kodeHapus}';";

                Koneksi.JalankanPerintahNonQuery(cmd);

            }
            catch (Exception x)
            {
                throw x;
            }
        }

        //Method INSERT
        public static void TambahData(Aktor act)
        {
            string cmd = $"INSERT INTO aktors(nama, tgl_lahir, gender, negara_asal) VALUES('{act.Nama}', " +
                $"'{act.Tgl_Lahir.ToString("yyyy-MM-dd")}', '{act.Gender}', '{act.Negara_Asal}'); ";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        public static void TambahAktorFilm(Film f, Aktor a, string peran)
        {
            string query = $"INSERT INTO aktor_film (aktors_id, films_id, peran) VALUES ('{a.ID}', '{f.Id}', '{peran}');";
            Koneksi.JalankanPerintahNonQuery(query);
        }

        public static void UpdateData(Aktor act)
        {
            string cmd = $"UPDATE aktors SET nama = '{act.Nama}', tgl_lahir = '{act.Tgl_Lahir.ToString("yyyy-MM-dd")}'," +
                $" gender = '{act.Gender}', negara_asal = '{act.Negara_Asal}' WHERE id = {act.ID};";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        #endregion
    }
}
