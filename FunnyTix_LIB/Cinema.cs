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
                string cmd = $"DELETE FROM cinemas WHERE id = '{kodeHapus}';";

                Koneksi.JalankanPerintahNonQuery(cmd);
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public override string ToString()
        {
            return NamaCabang;
        }
        #endregion
    }
}
