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
        public static List<Aktor> BacaData(string filter="", string val ="")
        {
            try
            {
                List<Aktor> listAktor = new List<Aktor>();
                string cmd = (filter == String.Empty) ? $"SELECT * FROM aktors;" : $"select * from aktors where {filter} like '%{val}%';";

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
                throw new Exception("Unsuccess!");
            }
            
        }
        
        //Method DELETE
        public static void DeleteData(Aktor act)
        {
            try
            {
                string cmd = $"DELETE FROM aktors where id = {act.ID};";

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
                $"{act.Tgl_Lahir.ToString("yyyy-MM-dd")}, '{act.Gender}', '{act.Negara_Asal}'); ";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }

        public static void UpdateData(Aktor act)
        {
            string cmd = $"UPDATE aktors SET negara_asal = '{act.Negara_Asal}' WHERE id = {act.ID};";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        #endregion
    }
}
