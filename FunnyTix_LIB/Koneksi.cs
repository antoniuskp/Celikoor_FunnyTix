using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace FunnyTix_LIB
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }

        public Koneksi(string pServer, string pDb, string pUid, string pPwd)
        {
            string vConnString = "Server=" + pServer + ";Database=" + pDb + ";Uid=" + pUid + ";Pwd=" + pPwd + ";";

            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = vConnString;

            Connect();
        }

        public Koneksi()
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSetting = myConf.SectionGroups["userSettings"];
            var settingSection = userSetting.Sections["Celikoor_FunnyTix.db"] as ClientSettingsSection;
            string vServer = settingSection.Settings.Get("dbServer").Value.ValueXml.InnerText;
            string vDb = settingSection.Settings.Get("dbName").Value.ValueXml.InnerText;
            string vUID = settingSection.Settings.Get("dbUid").Value.ValueXml.InnerText;
            string vPWD = settingSection.Settings.Get("dbPwd").Value.ValueXml.InnerText;

            string vConnString = "Server=" + vServer + ";Database=" + vDb + ";Uid=" + vUID + ";Pwd=" + vPWD + ";";

            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = vConnString;

            Connect();
        }
        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            else
            {
                KoneksiDB.Open();
            }
        }

        public static MySqlDataReader JalankanPerintahSelect(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand cmd = new MySqlCommand(sql, k.KoneksiDB);
            MySqlDataReader hasil = cmd.ExecuteReader();
            return hasil;
        }

        public static void JalankanPerintahNonQuery(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand cmd = new MySqlCommand(sql, k.KoneksiDB);
            cmd.ExecuteNonQuery();
        }
    }
}
