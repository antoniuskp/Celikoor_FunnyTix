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
        public static string GenerateUsernamePegawai(string role)
        {
            string usernameBaru = "";
            string query = "";
            if(role == "ADMIN")
            {
                query = $"SELECT username FROM pegawais WHERE username LIKE 'A%' ORDER BY id DESC LIMIT 1;";
            }
            else if(role == "KASIR")
            {
                query = $"SELECT username FROM pegawais WHERE username LIKE 'K%' ORDER BY id DESC LIMIT 1;";

            }
            else if(role == "OPERATOR")
            {
                query = $"SELECT username FROM pegawais WHERE username LIKE 'O%' ORDER BY id DESC LIMIT 1;";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            if (hasil.Read() == true)
            {
                string noNotaAkhir = hasil.GetValue(0).ToString().Substring(1);
                int number = int.Parse(noNotaAkhir);
                number += 1;
                string output = number.ToString("D3");

                if (role == "ADMIN")
                {
                    usernameBaru = "A" + output;
                }
                else if(role == "KASIR")
                {
                    usernameBaru = "K" + output;
                }
                else if (role == "OPERATOR")
                {
                    usernameBaru = "O" + output;
                }
            }
            return usernameBaru;
        }

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

                string cmd = $"delete from tikets WHERE operator_id = '{kodeHapus}'";
                Koneksi.JalankanPerintahNonQuery(cmd);

                cmd = $"SELECT id from invoices WHERE kasir_id = '{kodeHapus}'";

                var res = Koneksi.JalankanPerintahSelect(cmd);
                var listInvoies_id = new List<int>();

                while (res.Read() == true)
                {
                    listInvoies_id.Add(res.GetInt32(0));
                }

                foreach (int id in listInvoies_id)
                {
                    cmd = $"DELETE from tikets WHERE invoices_id = '{id}'";
                    Koneksi.JalankanPerintahNonQuery(cmd);
                }

                cmd = $"DELETE from invoices WHERE kasir_id = '{kodeHapus}'";
                Koneksi.JalankanPerintahNonQuery(cmd);

                cmd = $"DELETE from pegawais where id='{kodeHapus}';";
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

        public override string ToString()
        {
            return this.Nama;
        }
        #endregion
    }
}
