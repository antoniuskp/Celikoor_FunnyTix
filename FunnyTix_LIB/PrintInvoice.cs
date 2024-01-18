using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace FunnyTix_LIB
{
    public class PrintInvoice
    {
        private string nomorKursi;
        private double harga;
        private JadwalFilm pjadwalFilm;
        private Studio pstudio;
        private Film pfilm;

        public PrintInvoice()
        {
            NomorKursi = "";
            Harga = 0;
            PjadwalFilm = new JadwalFilm();
            Pstudio = new Studio();
            Pfilm = new Film();
        }

        public string NomorKursi { get => nomorKursi; set => nomorKursi = value; }
        public double Harga { get => harga; set => harga = value; }
        public JadwalFilm PjadwalFilm { get => pjadwalFilm; set => pjadwalFilm = value; }
        public Studio Pstudio { get => pstudio; set => pstudio = value; }
        public Film Pfilm { get => pfilm; set => pfilm = value; }

        public static List<PrintInvoice> Print(string kodeInvoice)
        {

            string query = $"select * from tikets where invoices_id = '{kodeInvoice}'; ";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<PrintInvoice> listTiket = new List<PrintInvoice>();

            while(hasil.Read()==true)
            {
                PrintInvoice tampung = new PrintInvoice();
                tampung.NomorKursi = hasil.GetValue(1).ToString();
                tampung.Harga = double.Parse(hasil.GetValue(4).ToString());
                tampung.PjadwalFilm = JadwalFilm.BacaData("id", hasil.GetValue(5).ToString())[0];
                tampung.Pstudio = Studio.BacaData("id", hasil.GetValue(6).ToString())[0];
                tampung.Pfilm = Film.BacaData("id", hasil.GetValue(7).ToString())[0];
                listTiket.Add(tampung);
            }
            return listTiket;
        }

        public static void CetakInvoice(string kodeInvoice, List<PrintInvoice> listPrint)
        {
            string nama = "Laporan_" + kodeInvoice;
            StreamWriter NamaFile = new StreamWriter(nama);

            Invoice invoice = Invoice.BacaData("id", kodeInvoice)[0];
            NamaFile.WriteLine("No.Pesanan = " + invoice.Tanggal.ToString("yyyyMMdd") + kodeInvoice.PadLeft(6, '0'));
            NamaFile.WriteLine("--------------------------------------------------------------------------");
            NamaFile.WriteLine("Total Pembayaran                        " + "Waktu Pemesanan");
            NamaFile.WriteLine("Rp. " + invoice.GrandTotal.ToString().PadRight(36, ' ') + invoice.Tanggal.ToString("dd/MM/yyyy"));
            NamaFile.WriteLine("--------------------------------------------------------------------------");
            NamaFile.WriteLine("Rincian Konsumen");
            NamaFile.WriteLine(invoice.Konsumen.Nama);
            NamaFile.WriteLine(invoice.Konsumen.No_Hp);
            NamaFile.WriteLine("--------------------------------------------------------------------------");
            NamaFile.WriteLine("Rincian Pemesanan");
            NamaFile.WriteLine("Studio    |Film           |Jadwal Film         |Nomor Kursi|Harga");
            double subtotal = 0;
            for(int i =0; i<listPrint.Count; i++)
            {
                string studio = "";
                if(listPrint[i].Pstudio.Nama.Length>10)
                {
                    studio = listPrint[i].Pstudio.Nama.Substring(0, 10);
                }
                else
                {
                    studio = listPrint[i].Pstudio.Nama.PadRight(10, ' ');
                }
                string film = "";
                if (listPrint[i].Pfilm.Judul.Length > 15)
                {
                    film = listPrint[i].Pfilm.Judul.Substring(0, 15);
                }
                else
                {
                    film = listPrint[i].Pfilm.Judul.PadRight(15,' ');
                }
                string jadwalFilm = JadwalFilm.SesiToJam(listPrint[i].PjadwalFilm.Jam_pemutaran).PadRight(20, ' ');
                string nomorKursi = listPrint[i].NomorKursi.PadRight(11, ' ');
                string harga = listPrint[i].Harga.ToString();
                subtotal += listPrint[i].Harga;

                NamaFile.WriteLine(studio + "|" + film + "|" + jadwalFilm + "|" + nomorKursi + "|" + harga);
            }
            NamaFile.WriteLine("--------------------------------------------------------------------------");
            NamaFile.WriteLine("Subtotal            Rp. " + subtotal.ToString());
            NamaFile.WriteLine("Total Diskon        Rp. " + invoice.DiskonNominal.ToString());
            NamaFile.WriteLine("Total Pembayaran    Rp. " + invoice.GrandTotal.ToString());
            NamaFile.WriteLine("------------------------------F U N N Y T I X------------------------------");

            NamaFile.Close();

            CustomPrint p = new CustomPrint(new System.Drawing.Font("courier new", 12), nama);
            p.KirimPrinter();
        }
    }
}
