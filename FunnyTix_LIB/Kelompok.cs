using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyTix_LIB
{
    public class Kelompok
    {
        #region PROPERTIES
        public int ID { get; set; }
        public string Nama { get; set; }
        #endregion

        #region CONSTRUCTOR
        public Kelompok(string nama)
        {
            ID = 0;
            Nama = nama;
        }
        public Kelompok()
        {
            ID = 0;
            Nama = "";
        }
        #endregion

        #region METHODS
        public static List<Kelompok> BacaData(string filter = "", string val = "")
        {
            string cmd = (filter == "") ? $"SELECT * FROM kelompoks" : $"SELECT * FROM kelompoks WHERE {filter} LIKE '%{val}%';";

            MySqlDataReader res = Koneksi.JalankanPerintahSelect(cmd);

            var lstKelompok = new List<Kelompok>();
            while (res.Read() == true)
            {
                Kelompok k = new Kelompok(res.GetValue(1).ToString());

                lstKelompok.Add(k);
            }
            return lstKelompok;
        }
        public static void TambahData(Kelompok k)
        {
            string cmd = $"INSERT INTO kelompoks(nama) VALUES ('{k.Nama}');";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        public static void DeleteData(Kelompok k)
        {
            string cmd = $"DELETE FROM kelompoks WHERE id = '{k.ID}';";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        #endregion
    }
}
