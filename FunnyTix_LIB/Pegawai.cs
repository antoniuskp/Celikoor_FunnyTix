using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public class Pegawai
    {
        #region PROPERTIES
        public int ID { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
        #endregion

        #region CONSTRUCTOR
        public Pegawai(string nama, string email, string username, string password, string roles)
        {
            ID =0;
            Nama = nama;
            Email = email;
            Username = username;
            Password = password;
            Roles = roles;
        }
        public Pegawai()
        {
            ID =0;
            Nama = "";
            Email = "";
            Username = "";
            Password = "";
            Roles = "";
        }
        #endregion

        #region METHOD
        //TODO Create
        public static void TambahData(Pegawai pegawai)
        {
            string cmd = $"INSERT INTO pegawais (nama, email, username, password, roles) VALUES " +
                $"('{pegawai.Nama}', '{pegawai.Email}', '{pegawai.Username}', '{pegawai.Password}', '{pegawai.Roles}');";

            Koneksi.JalankanPerintahNonQuery(cmd);  //! Masukkan data ke Tabel Konsumen
        }

        //TODO Read
        public static List<Pegawai> BacaData(string filter = "", string val = "")
        {

            string cmd = (filter == "") ? $"SELECT * FROM pegawais;" : $"SELECT * FROM pegawais WHERE {filter} LIKE '%{val}%';";

            MySqlDataReader res = Koneksi.JalankanPerintahSelect(cmd);

            var listPegawai = new List<Pegawai>();

            while (res.Read() == true)
            {
                Pegawai p = new Pegawai(
                        res.GetValue(1).ToString(),
                        res.GetValue(2).ToString(),
                        res.GetValue(3).ToString(),
                        "",
                        res.GetValue(5).ToString()
                        );

                p.ID = int.Parse(res.GetValue(0).ToString());

                listPegawai.Add(p);
            }

            return listPegawai;
        }

        //TODO Delete
        public static void DeleteData(string kodeHapus)
        {
            try
            {
                string cmd = $"DELETE FROM pegawais WHERE id = '{kodeHapus}';";

                Koneksi.JalankanPerintahNonQuery(cmd);
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        //CEK LOGIN 
        public static Pegawai CekLogin(string username, string password)
        {
            string cmd = "SELECT * FROM pegawais WHERE Username='" + username + "' AND Password ='" + password + "';";

            MySqlDataReader res = Koneksi.JalankanPerintahSelect(cmd);

            if (res.Read() == true) //selama masih ada data atau masih bisa membaca data (menggunakan if soalnya yang diharapkan hanya 1 yang terbaca)
            {
                Pegawai p = new Pegawai(
                        res.GetValue(1).ToString(),
                        res.GetValue(2).ToString(),
                        res.GetValue(3).ToString(),
                        "",
                        res.GetValue(5).ToString()
                        );

                p.ID = int.Parse(res.GetValue(0).ToString());

                return p; //return == kembali ke yang memanggil (tanda transaksi sudah selesay)
            }
            return null; //return null dijalankan kalo tidak masuk ke if

        }
        #endregion
    }
}
