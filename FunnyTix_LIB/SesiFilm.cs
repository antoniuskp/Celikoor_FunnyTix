using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public class SesiFilm
    {
        #region DATA MEMBER
        private JadwalFilm jadwalFilm;
        private Studio studio;
        private Film film;
        #endregion

        #region PROPERTIES
        public JadwalFilm JadwalFilm { get => jadwalFilm; set => jadwalFilm = value; }
        public Studio Studio { get => studio; set => studio = value; }
        public Film Film { get => film; set => film = value; }
        #endregion

        #region CONSTRUCTOR
        public SesiFilm(JadwalFilm jadwalFilm, Studio studio, Film film)
        {
            JadwalFilm = jadwalFilm;
            Studio = studio;
            Film = film;
        }
        public SesiFilm()
        {
            JadwalFilm = new JadwalFilm();
            Studio = new Studio();
            Film = new Film();
        }
        #endregion

        #region METHOD
        public static void TambahData(SesiFilm sesiFilm)
        {
            if (SesiFilm.BacaData(sesiFilm.JadwalFilm.Id.ToString(), sesiFilm.Studio.ID.ToString(), sesiFilm.Film.Id.ToString()).Count > 0)
            {
                throw new Exception("Credentials have taken!");
            }

            string cmd = $"INSERT INTO SESI_FILMS (jadwal_film_id, studios_id, films_id) VALUES " +
                $"('{sesiFilm.JadwalFilm.Id}', '{sesiFilm.Studio.ID}', '{sesiFilm.Film.Id}');";

            Koneksi.JalankanPerintahNonQuery(cmd);  //! Masukkan data ke Tabel Konsumen
        }

        public static List<SesiFilm> BacaData(string val = "", string val2 = "", string val3="")
        {

            string cmd = (val == "") ? $"SELECT * FROM SESI_FILMS;" : $"SELECT * FROM SESI_FILMS WHERE jadwal_film_id LIKE '%{val}%' AND studios_id LIKE '%{val2}%' AND films_id LIKE '%{val3}%';";

            MySqlDataReader res = Koneksi.JalankanPerintahSelect(cmd);

            var listSesiFilm = new List<SesiFilm>();

            while (res.Read() == true)
            {
                SesiFilm sF = new SesiFilm(
                        JadwalFilm.BacaData(res.GetValue(0).ToString())[0],
                        Studio.BacaData("id", res.GetValue(1).ToString())[0],
                        Film.BacaData(res.GetValue(2).ToString())[0]
                    );

                listSesiFilm.Add(sF);
            }

            return listSesiFilm;
        }
        public static void DeleteData(SesiFilm sesiFilm)
        {
            try
            {
                string cmd = $"DELETE FROM SESI_FILMS WHERE jadwal_film_id LIKE '%{sesiFilm.jadwalFilm.Id}%' AND studios_id LIKE '%{sesiFilm.Studio.ID}%' AND films_id LIKE '%{sesiFilm.Film.Id}%';";

                Koneksi.JalankanPerintahNonQuery(cmd);
            }
            catch (Exception x)
            {
                throw x;
            }
        }
        #endregion
    }
}
