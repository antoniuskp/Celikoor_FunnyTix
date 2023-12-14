using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FunnyTix_LIB
{
    public class Laporan
    {
        private string judulFilm;
        private int jumlahTonton;
        private int bulan;

        private string cabang;
        private int grandTotal;

        private string namaStudio;
        private int tingkatUtilitas;

        private string namaKonsumen;
        private int frekuensi;

        public Laporan()
        {
            judulFilm = "";
            jumlahTonton = 0;
            bulan= 0;

            cabang = "";
            grandTotal = 0;

            namaStudio = "";
            tingkatUtilitas= 0;

            namaKonsumen = "";
            Frekuensi = 0;
        }

        public string JudulFilm { get => judulFilm; set => judulFilm = value; }
        public int JumlahTonton { get => jumlahTonton; set => jumlahTonton = value; }
        public int Bulan { get => bulan; set => bulan = value; }

        public string Cabang { get => cabang; set => cabang = value; }
        public int GrandTotal { get => grandTotal; set => grandTotal = value; }

        public string NamaStudio { get => namaStudio; set => namaStudio = value; }
        public int TingkatUtilitas { get => tingkatUtilitas; set => tingkatUtilitas = value; }

        public string NamaKonsumen { get => namaKonsumen; set => namaKonsumen = value; }
        public int Frekuensi { get => frekuensi; set => frekuensi = value; }


        public static List<Laporan> laporanA()
        {
            string query = $" select f.judul, count(i.id) as jumlah_ditonton, month(i.tanggal) as Bulan" +
                             " from invoices as i inner join tikets as t on i.id = t.invoices_id " +
                             " inner join sesi_films as sf on t.jadwal_film_id = sf.jadwal_film_id and t.studios_id = sf.studios_id and t.films_id = sf.films_id " +
                             " inner join film_studio as fs on sf.studios_id = fs.studios_id and sf.films_id = fs.films_id " +
                             " inner join films as f on fs.films_id = f.id " +
                             " where month(i.tanggal) = '11' " +
                             " group by f.judul " +
                             " order by jumlah_ditonton desc " +
                             " limit 3;";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<Laporan> listLaporan = new List<Laporan>();

            while (hasil.Read() == true)
            {
                Laporan l = new Laporan();
                l.JudulFilm = hasil.GetValue(0).ToString();
                l.JumlahTonton = int.Parse(hasil.GetValue(1).ToString());
                l.Bulan = int.Parse(hasil.GetValue(2).ToString());
                listLaporan.Add(l);
            }
            return listLaporan;
        }

        public static List<Laporan> laporanB()
        {
            string query = $" SELECT DISTINCT c.nama_cabang, sum(i.grand_total) as total_pemasukan FROM cinemas c " +
                            " INNER JOIN studios s on c.id = s.cinemas_id" +
                            " INNER JOIN film_studio fs on fs.studios_id = s.id " +
                            " INNER JOIN sesi_films sf on sf.studios_id = fs.studios_id " +
                            " INNER JOIN tikets t on t.studios_id = sf.studios_id " +
                            " INNER JOIN invoices i on i.id = t.invoices_id" +
                            " GROUP BY c.nama_cabang " +
                            " ORDER BY total_pemasukan DESC" +
                            " LIMIT 3; ";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<Laporan> listLaporan = new List<Laporan>();

            while (hasil.Read() == true)
            {
                Laporan l = new Laporan();
                l.cabang = hasil.GetValue(0).ToString();
                l.grandTotal = int.Parse(hasil.GetValue(1).ToString());
                listLaporan.Add(l);
            }
            return listLaporan;
        }

        public static List<Laporan> laporanC()
        {
            string query = $" select f.judul from invoices as i " +
                            " inner join tikets as t on i.id = t.invoices_id " +
                            " inner join sesi_films as sf on " +
                            " t.films_id = sf.films_id and " + " t.jadwal_film_id = sf.jadwal_film_id and " +
                            " t.studios_id = sf.studios_id" +
                            " inner join film_studio fs on" +
                            " sf.studios_id = fs.studios_id and " +
                            " sf.films_id = fs.films_id " +
                            " inner join films as f on " +
                            " fs.films_id = f.id " +
                            " where t.status_hadir = 0 "+
                            " group by f.judul " +
                            " order by count(i.id) desc " +
                            " limit 3; ";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<Laporan> listLaporan = new List<Laporan>();

            while (hasil.Read() == true)
            {
                Laporan l = new Laporan();
                l.JudulFilm = hasil.GetValue(0).ToString();
                listLaporan.Add(l);
            }
            return listLaporan;
        }

        public static List<Laporan> laporanD()
        {
            List<Laporan> listLaporan = new List<Laporan>();
            for (int i=1; i<=12; i++)
            {
                string query = $" Select c.nama_cabang, s.nama, month(jf.tanggal) as bulan, (s.kapasitas - count(t.nomor_kursi)) as tingkatUtilitas " +
                            " from studios as s right join cinemas as c on c.id = s.cinemas_id " +
                            " inner join film_studio as fs on s.id = fs.studios_id " +
                            " inner join sesi_films as sf on fs.studios_id = sf.studios_id and fs.films_id = sf.films_id " +
                            " inner join jadwal_films as jf on sf.jadwal_film_id = jf.id " +
                            " inner join tikets as t on sf.jadwal_film_id = t.jadwal_film_id and sf.studios_id = t.studios_id and sf.films_id = t.films_id " +
                            $" where month(jf.tanggal)= {i} " +
                            " group by s.nama " +
                            " order by tingkatUtilitas desc " +
                            " limit 3; ";
                MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
                while (hasil.Read() == true)
                {
                    Laporan l = new Laporan();
                    l.Cabang = hasil.GetValue(0).ToString();
                    l.NamaStudio = hasil.GetValue(1).ToString();
                    l.Bulan = int.Parse(hasil.GetValue(2).ToString());
                    l.TingkatUtilitas = int.Parse(hasil.GetValue(3).ToString());

                    listLaporan.Add(l);
                }
            }
            return listLaporan;
        }
        public static List<Laporan> laporanE()
        {
            string query = $" select k.nama as Konsumen, count(t.nomor_kursi) as Frekuensi " + 
                            " from konsumens as k " +
                            " inner join invoices as i on k.id = i.konsumens_id " + 
                            " inner join tikets as t on i.id = t.invoices_id " +
                            " inner join sesi_films as sf on " +
                            " t.films_id = sf.films_id and " +
                            " t.jadwal_film_id = sf.jadwal_film_id and " +
                            " t.studios_id = sf.studios_id " +
                            " inner join film_studio as fs on sf.studios_id = fs.studios_id and sf.films_id = fs.films_id " +
                            " inner join films as f on fs.films_id = f.id " +
                            " inner join genre_film as gf on f.id = gf.films_id " +
                            " inner join genres as g on gf.genres_id = g.id " +
                            " where g.nama = 'Komedi' group by k.nama order by count(t.nomor_kursi) desc limit 10; ";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<Laporan> listLaporan = new List<Laporan>();

            while (hasil.Read() == true)
            {
                Laporan l = new Laporan();
                l.NamaKonsumen = hasil.GetValue(0).ToString();
                l.Frekuensi = int.Parse(hasil.GetValue(1).ToString());

                listLaporan.Add(l);
            }
            return listLaporan;
        }
    }

    
}
