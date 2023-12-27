using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public class Konsumen
    {
        #region PROPERTIES
        public int ID { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string No_Hp { get; set; }
        public string Gender { get; set; }
        public DateTime Tgl_lahir { get; set; }
        public double Saldo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        #endregion

        #region CONSTRUCTOR
        public Konsumen(string nama, string email, string no_hp, string gender, DateTime tgl_lahir, double saldo, string username, string password)
        {
            this.ID = 0;
            this.Nama = nama;
            this.Email = email;
            this.No_Hp = no_hp;
            this.Gender = gender;
            this.Tgl_lahir = tgl_lahir == null ?  DateTime.Now : tgl_lahir;
            this.Saldo = saldo;
            this.Username = username;
            this.Password = password;
        }
        public Konsumen()
        {
            this.ID = 0;
            this.Nama = "";
            this.Email = "";
            this.No_Hp = "";
            this.Gender = "";
            this.Tgl_lahir = DateTime.Now;
            this.Saldo = 0;
            this.Username = "";
            this.Password = "";
        }
        #endregion

        #region METHODS
        //TODO: Create
        public static void TambahData(Konsumen konsumen)
        {
            if (Konsumen.BacaData("username", konsumen.Username).Count > 0)
            {
                throw new Exception("Credentials have taken!");
            }

            string cmd = $"INSERT INTO konsumens (nama, email, no_hp, gender, tgl_lahir, saldo, username, password) VALUES " +
                $"('{konsumen.Nama}', '{konsumen.Email}', '{konsumen.No_Hp}', '{konsumen.Gender}', '{konsumen.Tgl_lahir.ToString("yyyy-MM-dd")}', " +
                $"'{konsumen.Saldo.ToString()}', '{konsumen.Username}', '{konsumen.Password}');";

            Koneksi.JalankanPerintahNonQuery(cmd);  //! Masukkan data ke Tabel Konsumen
        }

        //TODO: Read
        public static List<Konsumen> BacaData(string filter="", string val="")
        {

            string cmd = (filter == "") ? $"SELECT * FROM konsumens;" : $"SELECT * FROM konsumens WHERE {filter} LIKE '%{val}%';";

            MySqlDataReader res = Koneksi.JalankanPerintahSelect(cmd);

            var lstKonsumen = new List<Konsumen>();

            while (res.Read() == true)
            {
                Konsumen k = new Konsumen(
                        res.GetValue(1).ToString(),
                        res.GetValue(2).ToString(),
                        res.GetValue(3).ToString(),
                        res.GetValue(4).ToString(),
                        DateTime.Parse(res.GetValue(5).ToString()),
                        res.GetDouble(6),
                        res.GetValue(7).ToString(),
                        ""
                    );

                k.ID = int.Parse(res.GetValue(0).ToString());

                lstKonsumen.Add(k);
            }

            return lstKonsumen;
        }

        //TODO: Update
        public static void UbahData(string param, string val, Konsumen konsumen)
        {
            try
            {
                string cmd= $"UPDATE konsumens SET {param} = '{val}' WHERE id='{konsumen.ID}';";
            

                Koneksi.JalankanPerintahNonQuery(cmd);  //! Kirim command
            }
            catch (Exception x)
            {
                throw new Exception("Error: " + x.Message);
            }
        }

        public static void UpdateSaldo(double val, Konsumen konsumen)
        {
            try
            {
                if (konsumen.Saldo - val < 0)
                {
                    throw new Exception("Saldo anda tidak cukup!");
                }
                
                double currSaldo = konsumen.Saldo - val;
                UbahData("saldo", currSaldo.ToString(), konsumen);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void TopUp(double val, Konsumen konsumen)
        {
            double currSaldo = konsumen.Saldo + val;
            UbahData("saldo", currSaldo.ToString(), konsumen);
        }

        //TODO: Delete
        public static void DeleteData(string kodeHapus)
        {
            try
            {
                string cmd = $"DELETE FROM konsumens WHERE id = '{kodeHapus}';";

                Koneksi.JalankanPerintahNonQuery(cmd);
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        //CEK LOGIN 
        public static Konsumen CekLogin(string username, string password)
        {
            string cmd = "SELECT * FROM konsumens WHERE Username='" + username + "' AND Password ='" + password + "';";

            MySqlDataReader res = Koneksi.JalankanPerintahSelect(cmd);

            if (res.Read() == true) //selama masih ada data atau masih bisa membaca data (menggunakan if soalnya yang diharapkan hanya 1 yang terbaca)
            {
                Konsumen k = new Konsumen(
                        res.GetValue(1).ToString(),
                        res.GetValue(2).ToString(),
                        res.GetValue(3).ToString(),
                        res.GetValue(4).ToString(),
                        DateTime.Parse(res.GetValue(5).ToString()),
                        res.GetDouble(6),
                        res.GetValue(7).ToString(),
                        ""
                    );

                k.ID = int.Parse(res.GetValue(0).ToString());

                return k; //return == kembali ke yang memanggil (tanda transaksi sudah selesay)
            }
            return null; //return null dijalankan kalo tidak masuk ke if

        }
        #endregion

    }
}
