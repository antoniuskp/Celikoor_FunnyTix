using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace FunnyTix_LIB
{
    public class Film
    {
        #region DATA MEMBERS
        private int id;
        private string judul;
        private string sinopsis;
        private int tahun;
        private int durasi;
        private Kelompok kelompok;
        private string bahasa;
        private int isSubIndo;
        private string coverImage;
        private double diskon;
        private List<AktorFilm> listAktor;
        private List<GenreFilm> listGenre;
        private List<FilmStudio> listFilmStudio;
        private List<SesiFilm> listSesiFilm;

        #endregion

        #region CONSTRUCTORS
        public Film(string judul, string sinopsis, int tahun, int durasi, Kelompok kelompok, string bahasa, int isSubIndo, string coverImange, double diskon)
        {
            this.Id =0;
            this.Judul = judul;
            this.Sinopsis = sinopsis;
            this.Tahun = tahun;
            this.Durasi = durasi;
            this.Kelompok = kelompok;
            this.Bahasa = bahasa;
            this.IsSubIndo = isSubIndo;
            this.CoverImange = coverImange;
            this.Diskon = diskon;
            this.ListAktor = new List<AktorFilm>();
            this.ListGenre = new List<GenreFilm>();
            this.ListSesiFilm = new List<SesiFilm>();
            this.ListFilmStudio = new List<FilmStudio>();
        }

        public Film()
        {
            this.Id = 0;
            this.Judul = "";
            this.Sinopsis = "";
            this.Tahun = 0;
            this.Durasi = 0;
            this.Kelompok = new Kelompok();
            this.Bahasa = "";
            this.IsSubIndo = 0;
            this.CoverImange = "";
            this.Diskon = 0;
            this.ListAktor = new List<AktorFilm>();
            this.ListGenre = new List<GenreFilm>();
            this.ListFilmStudio = new List<FilmStudio>();
            this.ListSesiFilm = new List<SesiFilm>();
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public int Durasi { get => durasi; set => durasi = value; }
        public Kelompok Kelompok { get => kelompok; set => kelompok = value; }
        public string Bahasa { get => bahasa; set => bahasa = value; }
        public int IsSubIndo { get => isSubIndo; set => isSubIndo = value; }
        public string CoverImange { get => coverImage; set => coverImage = value; }
        public double Diskon { get => diskon; set => diskon = value; }
        public List<AktorFilm> ListAktor { get => listAktor; set => listAktor = value; }
        public List<GenreFilm> ListGenre { get => listGenre; set => listGenre = value; }
        public List<FilmStudio> ListFilmStudio { get => listFilmStudio; set => listFilmStudio = value; }
        public List<SesiFilm> ListSesiFilm { get => listSesiFilm; set => listSesiFilm = value; }

        #endregion

        #region METHODS

        #region select
        public static List<Film> CariFilmTanpaStudio(Studio s)
        {
            string query = $"SELECT f.* FROM films f LEFT JOIN film_studio fs ON f.id = fs.films_id AND fs.studios_id = '{s.ID}' WHERE fs.films_id IS NULL;";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            List<Film> listFilm = new List<Film>();
            while(hasil.Read() == true)
            {
                Film f = new Film();
                f.Id = int.Parse(hasil.GetValue(0).ToString());
                f.Judul = hasil.GetValue(1).ToString();
                f.Sinopsis = hasil.GetValue(2).ToString();
                f.Tahun = int.Parse(hasil.GetValue(3).ToString());
                f.Durasi = int.Parse(hasil.GetValue(4).ToString());

                Kelompok k = new Kelompok();
                k.ID = int.Parse(hasil.GetValue(5).ToString());

                f.Kelompok = k;
                f.Bahasa = hasil.GetValue(6).ToString();
                f.IsSubIndo = int.Parse(hasil.GetValue(7).ToString());
                f.coverImage = hasil.GetValue(8).ToString();
                f.Diskon = int.Parse(hasil.GetValue(9).ToString());
                listFilm.Add(f);
            }
            return listFilm;
        }

        public void BacaGenreFilm(Film f)
        {
            string query = $"SELECT DISTINCT genres_id FROM genre_film WHERE films_id = '{f.Id}';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            while (hasil.Read() == true)
            {
                GenreFilm gf = new GenreFilm();
                gf.Genre = Genre.BacaData("id", hasil.GetValue(0).ToString())[0];
                f.ListGenre.Add(gf);
            }
        }

        public void BacaAktorFilm(Film f)
        {
            string query = $"SELECT * FROM aktor_film WHERE films_id = {f.Id};";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            while(hasil.Read() == true)
            {
                AktorFilm af = new AktorFilm();
                af.Aktor = Aktor.BacaData("id", hasil.GetValue(0).ToString())[0];
                f.ListAktor.Add(af);
            }
            
        }

        //public void CariJadwalKosong(Film f, Studio s)
        //{
        //    string query = $"SELECT DISTINCT jf.* FROM jadwal_films jf LEFT JOIN sesi_films sf on sf.jadwal_film_id = jf.id WHERE sf.films_id = '{f.Id}' is null AND sf.studios_id = '{s.ID}' is null; ";

        //    MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

        //    while (hasil.Read() == true)
        //    {
        //        SesiFilm sf = new SesiFilm();
        //        sf.JadwalFilm = JadwalFilm.BacaData(hasil.GetValue(0).ToString())[0];
        //        f.ListSesiFilm.Add(sf);
        //    }
        //}


        public static DataTable CariCinema(int fid, string tgl)
        {
            var data = new DataTable("Daftar Cinema");
            data.Columns.Add("nama_cabang", typeof(string));

            string cmd = $"select distinct c.nama_cabang " +
                $"from jadwal_films as jf " +
                $"inner  join sesi_films as sf on jf.id = sf.jadwal_film_id " +
                $"inner join film_studio as fs on sf.films_id = fs.films_id " +
                $"inner join films as f on fs.films_id = f.id " +
                $"inner join studios as s on fs.studios_id = s.id " +
                $"inner join cinemas as c on s.cinemas_id = c.id " +
                $"where f.id = '{fid}' and jf.tanggal = '{tgl}';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(cmd);

            while (hasil.Read() == true)
            {
                DataRow row = data.NewRow();
                row["nama_cabang"] = hasil.GetValue(0).ToString();
                data.Rows.Add(row);
            }

            return data;
        }

        public static DataTable CariJadwalPemutaran(int fid, DateTime tgl, string cinema, string studio)
        {
            var data = new DataTable("Daftar Jam Pemutaran");
            data.Columns.Add("Jam Pemutaran", typeof(string));

            string cmd = $"select distinct jf.jam_pemutaran " +
                $"from jadwal_films as jf " +
                $"inner join sesi_films as sf on jf.id = sf.jadwal_film_id " +
                $"inner join film_studio as fs on sf.films_id = fs.films_id " +
                $"inner join films as f on fs.films_id = f.id " +
                $"inner join studios as s on fs.studios_id = s.id " +
                $"inner join cinemas as c on s.cinemas_id = c.id " +
                $"where f.id = '{fid}' and jf.tanggal = '{tgl.ToString("yyyy-MM-dd")}' and c.nama_cabang = '{cinema}' and s.nama = '{studio}';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(cmd);

            while (hasil.Read() == true)
            {
                DataRow row = data.NewRow();
                row["Jam Pemutaran"] = hasil.GetValue(0).ToString();
                data.Rows.Add(row);
            }

            return data;
        }

        public static DataTable CariStudio(int fid, DateTime tgl, Cinema cinema)
        {
            var data = new DataTable("Daftar Studio");
            data.Columns.Add("Studio", typeof(string));

            string cmd = $"SELECT DISTINCT s.nama FROM jadwal_films as jf INNER JOIN sesi_films AS sf ON jf.id = sf.jadwal_film_id INNER JOIN film_studio AS fs ON sf.films_id = fs.films_id INNER JOIN films as f on fs.films_id = f.id INNER JOIN studios as s on fs.studios_id = s.id INNER JOIN cinemas as c on s.cinemas_id = c.id WHERE f.id = '{fid}' and jf.tanggal = '{tgl.ToString("yyyy-MM-dd")}' AND c.nama_cabang = '{cinema.NamaCabang}';";


            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(cmd);

            while (hasil.Read() == true)
            {
                DataRow row = data.NewRow();
                row["Studio"] = hasil.GetValue(0).ToString();
                data.Rows.Add(row);
            }

            return data;
        }

        public static List<Film> BacaData(string value = "")
        {
            string query = "SELECT * FROM films;";
            if (value != "")
            {
                int kode = int.Parse(value);
                query = $"SELECT * FROM films where id = {kode};";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<Film> listFilm = new List<Film>();

            while (hasil.Read() == true)
            {
                Film film = new Film(
                    hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(),
                    int.Parse(hasil.GetValue(3).ToString()),
                    int.Parse(hasil.GetValue(4).ToString()),
                    Kelompok.BacaData("id", hasil.GetValue(5).ToString())[0],
                    hasil.GetValue(6).ToString(),
                    int.Parse(hasil.GetValue(7).ToString()), 
                    hasil.GetValue(8).ToString(),
                    double.Parse(hasil.GetValue(9).ToString()));

                film.Id = int.Parse(hasil.GetValue(0).ToString());
                listFilm.Add(film);
            }
            return listFilm;
        }

        public static List<Genre> ListGenreFilm(Film f)
        {
            string query = $"SELECT g.nama FROM genres AS g INNER JOIN genre_film gf on gf.genres_id = g.id INNER JOIN films f ON f.id = gf.films_id WHERE f.id = '{f.Id}';";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            List<Genre> listGenre = new List<Genre>();

            while(hasil.Read() == true)
            {
                Genre g = new Genre();
                g.Nama = hasil.GetValue(0).ToString();

                listGenre.Add(g);
            }
            return listGenre;
        }

        #endregion

        #region 
        public void TambahSesiFilm(Studio s, Film f, List<JadwalFilm> listJadwal)
        {
            FilmStudio fs = new FilmStudio();
            fs.Studio = s;
            fs.Film = f;
            ListFilmStudio.Add(fs);
            for(int i = 0; i < listJadwal.Count; i++)
            {
                SesiFilm sf = new SesiFilm();
                sf.FilmStudio = fs;
                sf.JadwalFilm = listJadwal[i];
                ListSesiFilm.Add(sf);
            }
        }


        public static void TambahDataSesiFilm(Film f)
        {
            //tambah Data ke film studio
            for (int i = 0; i < f.ListFilmStudio.Count; i++)
            {
                string query = $"INSERT INTO film_studio (studios_id, films_id) VALUES ('{f.ListFilmStudio[i].Studio.ID}','{f.ListFilmStudio[i].Film.Id}');";
                Koneksi.JalankanPerintahNonQuery(query);

                //Tambah data ke sesi films
                for (int j = 0; j < f.ListSesiFilm.Count; j++)
                {
                    //Pengecekan Jadwal Film 
                    string tanggal = f.ListSesiFilm[j].JadwalFilm.Tanggal.ToString("yyyy-MM-dd");
                    string jam = f.ListSesiFilm[j].JadwalFilm.JamPemutaran;
                    JadwalFilm jf = f.ListSesiFilm[j].JadwalFilm;
                    List<JadwalFilm> cari = JadwalFilm.BacaData("tanggal", tanggal, jam);
                    if (cari.Count == 0)
                    {
                        JadwalFilm.TambahData(jf);
                    }
                    Film.TambahDataSesiFilm(f.ListSesiFilm[j]);
                }
            }
        }
            

        public static void TambahDataSesiFilm(SesiFilm sf)
        {
            JadwalFilm jf = JadwalFilm.BacaData("tanggal", sf.JadwalFilm.Tanggal.ToString("yyyy-MM-dd"))[0];
            string query = $"INSERT INTO sesi_films (jadwal_film_id, studios_id, films_id) VALUES ('{jf.Id}', '{sf.FilmStudio.Studio.ID}', '{sf.FilmStudio.Film.Id}');";
            Koneksi.JalankanPerintahNonQuery(query);
        }
        public static void TambahData(Film film)
        {
            string cmd = $"INSERT INTO films (judul, sinopsis, tahun, durasi, kelompoks_id, bahasa, is_sub_indo, cover_image, diskon_nominal) values ('{film.Id}', '{film.Judul}','{film.Sinopsis}','{film.Tahun}','{film.Durasi}','{film.Kelompok.ID}','{film.Bahasa}','{film.IsSubIndo}','{film.CoverImange}','{film.Diskon}');";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        #endregion

        #region DELETE
        public static void DeleteData(Film film)
        {
            string cmd = $"UPDATE films set judul = '{film.Judul}', sinopsis = '{film.Sinopsis}', tahun = '{film.Tahun}', durasi = '{film.Durasi}', kelompoks_id = '{film.Kelompok.ID}', bahasa = '{film.Bahasa}', is_sub_indo = '{film.IsSubIndo}', cover_image = '{film.CoverImange}', diskon_nominal = '{film.Diskon}' where id = '{film.Id}';";

            Koneksi.JalankanPerintahNonQuery(cmd);
        }
        #endregion
        #endregion

    }
}

