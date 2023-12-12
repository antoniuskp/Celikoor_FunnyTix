using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public class AktorFilm
    {
        #region DATA MEMBER
        private Aktor aktor;
        private Film film;
        private string peran;
        #endregion

        #region PROPERTIES
        public Aktor Aktor { get => aktor; set => aktor = value; }
        public Film Film { get => film; set => film = value; }
        public string Peran { get => peran; set => peran = value; }
        #endregion

        #region CONSTRUCTOR
        public AktorFilm()
        {
            Aktor = new Aktor();
            Film = new Film();
            Peran = "";
        }

        public AktorFilm(Aktor aktor, Film film, string peran)
        {
            Aktor = aktor;
            Film = film;
            Peran = peran;
        }
        #endregion

        #region METHOD
        public static void TambahData(AktorFilm aktorFilm)
        {
            if (AktorFilm.BacaData("aktors_id", aktorFilm.Aktor.ID.ToString(), "film_id", aktorFilm.Film.Id.ToString()).Count > 0)
            {
                throw new Exception("Credentials have taken!");
            }

            string cmd = $"INSERT INTO aktor_film (aktors_id, films_id, peran) VALUES " +
                $"('{aktorFilm.Aktor.ID}', '{aktorFilm.Film.Id}', '{aktorFilm.Peran}');";

            Koneksi.JalankanPerintahNonQuery(cmd);  //! Masukkan data ke Tabel Konsumen
        }

        public static List<AktorFilm> BacaData(string filter = "", string val = "", string filter2 = "", string val2="")
        {

            string cmd = (filter == "") ? $"SELECT * FROM AKTOR_FILM;" : $"SELECT * FROM AKTOR_FILM WHERE {filter} LIKE '%{val}%' AND {filter2} LIKE '%{val2}%';";

            MySqlDataReader res = Koneksi.JalankanPerintahSelect(cmd);

            var listAktorFilm = new List<AktorFilm>();

            while (res.Read() == true)
            {
                AktorFilm aF = new AktorFilm(
                        Aktor.BacaData("id", res.GetValue(0).ToString())[0],
                        Film.BacaData(res.GetValue(1).ToString())[0],
                        res.GetValue(2).ToString()
                    );

                listAktorFilm.Add(aF);
            }

            return listAktorFilm;
        }

        public static void UbahData(string val, AktorFilm aktorFilm)
        {
            try
            {
                string cmd = $"UPDATE AKTOR_FILM SET peran = '{val}' WHERE aktors_id='{aktorFilm.Aktor.ID}' AND films'{aktorFilm.Film.Id}';";


                Koneksi.JalankanPerintahNonQuery(cmd);  //! Kirim command
            }
            catch (Exception x)
            {
                throw new Exception("Error: " + x.Message);
            }
        }
        public static void DeleteData(AktorFilm aktorFilm)
        {
            try
            {
                string cmd = $"DELETE FROM aktor_film WHERE aktors_id='{aktorFilm.Aktor.ID}' AND films'{aktorFilm.Film.Id}';";

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
