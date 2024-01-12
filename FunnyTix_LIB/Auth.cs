using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public static class Auth
    {
        private static string USERNAME;
        private static string PASSWORD;
        private static string ROLE;
        private static bool STATUS;

        /*TODO: Login (blm ambil yg login)
                bool status;
                Attempt("didik", "123", Role.KONSUMEN, out status)
                if (status)
                {
                    // Kalo berhasil login
                }
         */

        public static void Attempt(string username, string password, string role, out bool status)
        {
            if (role == Role.KONSUMEN)
            {
                string cmd = $"SELECT * FROM konsumens WHERE username='{username}' AND password='{password}';";

                MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(cmd);

                if (hasil.Read() == true)
                {
                    Konsumen konsumen = new Konsumen(
                            hasil.GetValue(1).ToString(),
                            hasil.GetValue(2).ToString(),
                            hasil.GetValue(3).ToString(),
                            hasil.GetValue(4).ToString(),
                            DateTime.Parse(hasil.GetValue(5).ToString()),
                            double.Parse(hasil.GetValue(6).ToString()),
                            hasil.GetValue(7).ToString(),
                            hasil.GetValue(8).ToString()
                        );


                    USERNAME = konsumen.Username;
                    PASSWORD = konsumen.Password;
                    ROLE = Role.KONSUMEN;
                    STATUS = true;
                    status = true;
                }
                else
                {
                    status = false;
                }
            }
            else if (role == Role.PEGAWAI)
            {
                string cmd = $"SELECT * FROM pegawais WHERE username='{username}' AND password='{password}';";

                MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(cmd);

                if (hasil.Read() == true)
                {
                    Pegawai pegawai = new Pegawai(
                            hasil.GetValue(1).ToString(),
                            hasil.GetValue(2).ToString(),
                            hasil.GetValue(3).ToString(),
                            hasil.GetValue(4).ToString(),
                            hasil.GetValue(5).ToString()
                        );

                    USERNAME = pegawai.Username;
                    PASSWORD = pegawai.Password;
                    ROLE = Role.PEGAWAI;
                    STATUS = true;
                    status = true;
                }
                else
                {
                    status = false;
                }
            }
            else
            {
                throw new Exception(role + " didn't recognized in our system!");
            }
        }

        /*TODO: 
                Mengambil user yang login sebagai konsumen
                PAKAI PADA FORM KONSUMEN
         */
        public static Konsumen GetKonsumen()
        {
            if (ROLE == Role.KONSUMEN && STATUS == true)
            {
                string cmd = $"SELECT * FROM konsumens WHERE username='{USERNAME}' AND password='{PASSWORD}';";

                MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(cmd);

                if (hasil.Read() == true)
                {
                    Konsumen konsumen = new Konsumen(
                            hasil.GetValue(1).ToString(),
                            hasil.GetValue(2).ToString(),
                            hasil.GetValue(3).ToString(),
                            hasil.GetValue(4).ToString(),
                            DateTime.Parse(hasil.GetValue(5).ToString()),
                            double.Parse(hasil.GetValue(6).ToString()),
                            hasil.GetValue(7).ToString(),
                            hasil.GetValue(8).ToString()
                        );
                    konsumen.ID = hasil.GetInt32(0);
                    return konsumen;
                }
                else
                {
                    throw new Exception("Error!");
                }
            }

            throw new Exception("Error!");
        }

        /*TODO: 
                Mengambil user yang login sebagai pegawai
                PAKAI PADA FORM PEGAWAI
         */
        public static Pegawai GetPegawai()
        {
            if (ROLE == Role.PEGAWAI && STATUS == true)
            {
                string cmd = $"SELECT * FROM pegawais WHERE username='{USERNAME}' AND password='{PASSWORD}';";

                MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(cmd);

                if (hasil.Read() == true)
                {
                    Pegawai pegawai = new Pegawai(
                            hasil.GetValue(1).ToString(),
                            hasil.GetValue(2).ToString(),
                            hasil.GetValue(3).ToString(),
                            hasil.GetValue(4).ToString(),
                            hasil.GetValue(5).ToString()
                        );
                    pegawai.ID = hasil.GetInt32(0);
                    return pegawai;
                }
                else
                {
                    throw new Exception("Error!");
                }
            }

            throw new Exception("Error!");
        }
        public static void LogOut()
        {
            Auth.USERNAME = null;
            Auth.ROLE = null;
            Auth.PASSWORD = null;
            Auth.STATUS = false;
        }
    }
}
