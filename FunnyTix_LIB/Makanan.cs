using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FunnyTix_LIB
{
    public class Makanan
    {
        #region DATA MEMBER
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Deskripsi { get; set; }
        #endregion


        #region PROPERTIES

        #endregion


        #region CONSTRUCTOR

        #endregion
        public Makanan()
        {
            Id = 0;
            Nama = "";
            Deskripsi = "";
        }

        #region METHODS
        public static List<Makanan> BacaData(string filter="", string val="")
        {
            string cmd = (filter == "") ? "SELECT * FROM makanans;" : $"SELECT * makanans WHERE {filter} LIKE '%{val}%'";

            var res = Koneksi.JalankanPerintahSelect(cmd);

            List<Makanan> lst = new List<Makanan>();

            while (res.Read())
            {
                Makanan makan = new Makanan();
                makan.Id = res.GetInt32(0);
                makan.Nama = res.GetValue(1).ToString();
                makan.Deskripsi = res.GetValue(2).ToString();

                lst.Add(makan);
            }

            return lst;
        }

        public static List<Makanan> SearchMakanan(string filter = "", string value = "")
        {
            string query = $"SELECT * FROM makanans where {filter} = '{value}';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<Makanan> listMakanan = new List<Makanan>();

            while (hasil.Read() == true)
            {
                Makanan mk = new Makanan();
                mk.Nama = hasil.GetValue(1).ToString();
                mk.Deskripsi = hasil.GetValue(2).ToString();
                mk.Id = int.Parse(hasil.GetValue(0).ToString());

                listMakanan.Add(mk);
            }
            return listMakanan;

        }
        public static Makanan CariMakanan(int id)
        {
            string cmd = $"SELECT * FROM makanans WHERE id = '{id}'";

            var res = Koneksi.JalankanPerintahSelect(cmd);

            if (res.Read())
            {
                Makanan makanan = new Makanan();
                makanan.Id = res.GetInt32(0);
                makanan.Nama = res.GetValue(1).ToString();
                makanan.Deskripsi = res.GetValue(2).ToString();

                return makanan;
            }

            return null;
        }

        public static List<Cinema> BacaCinemaMakanan()
        {
            string cmd = $"SELECT c.* FROM cinemas as c WHERE c.id IN (SELECT distinct mc.cinemas_id FROM makanans_cinemas as mc);";

            var res = Koneksi.JalankanPerintahSelect(cmd);

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
        public static void TambahData(Makanan mk)
        {
            string cmd = $"INSERT INTO makanans (nama, deskripsi) values ('{mk.Nama}', '{mk.Deskripsi}');";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        public static void HapusData(string kodeHapus)
        {
            string cmd = $"DELETE FROM makanans_cinemas WHERE makanans_id= '{kodeHapus}';";
            Koneksi.JalankanPerintahNonQuery(cmd);

            cmd = $"DELETE FROM makanans WHERE id= '{kodeHapus}';";
            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        #endregion
    }
}
