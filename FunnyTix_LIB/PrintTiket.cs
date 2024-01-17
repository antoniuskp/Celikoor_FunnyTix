using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FunnyTix_LIB
{
    public class PrintTiket
    {
        public PrintTiket()
        {
        }

        #region PRINT
        public void Print(string noKursi)
        {
            string query = $"SELECT t.* FROM tikets t WHERE t.nomor_kursi = '{noKursi}';";

            Tiket t;
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            if (hasil.Read() == true)
            {
                t = new Tiket();
                t.NoKursi = hasil.GetValue(1).ToString();
                Invoice i = new Invoice();
                i.Id = int.Parse(hasil.GetValue(0).ToString());
                t.IdInvoice = i;
                t.Status = false;

                if (hasil.GetValue(2).ToString() == "1")
                {
                    t.Status = true;
                }

                Pegawai p = new Pegawai();
                p.ID = int.Parse(hasil.GetValue(3).ToString());
                t.Operators = p;

                t.Harga = Double.Parse(hasil.GetValue(4).ToString());

                JadwalFilm j = new JadwalFilm();
                j.Id = int.Parse(hasil.GetValue(5).ToString());
                t.JadwalFilm = j;

                Studio s = new Studio();
                s.ID = int.Parse(hasil.GetValue(6).ToString());
                t.Studio = s;

                Film f = new Film();
                f.Id = int.Parse(hasil.GetValue(7).ToString());
                t.Film = f;

                //! Make Barcode based on invoice+noKursi
                string invoiceStr = t.IdInvoice.Id.ToString().PadLeft(3, '0');
                string kodeTiket = invoiceStr + noKursi;

                Zen.Barcode.BarcodeDraw brc = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;

                Image brcImage = brc.Draw(kodeTiket, 50);

                CredentialsTiket.Tiket_ = t;
                CredentialsTiket.BrcImage = brcImage;

                PrintDocument printer = new PrintDocument();
                printer.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                printer.PrintPage += new PrintPageEventHandler(PrintBarcode);
                printer.Print();
            }

        }

        private void PrintBarcode(object sender, PrintPageEventArgs e)
        {
            /*Bitmap bitmap = new Bitmap(barcode.Width, barcode.Height);
            barcode.DrawToBitmap(bitmap, new Rectangle(0, 0, barcode.Width, barcode.Height));
            Bitmap bitmap = new Bitmap(img);
            Font font = new Font("new courier", 12);
            e.Graphics.DrawImage(bitmap, 0, 0);
            e.Graphics.DrawString(kodeTiket, font, Brushes.DarkBlue, ((img.Width - kodeTiket.Length) / 2), 100);

            bitmap.Dispose();*/
            Image barcode = CredentialsTiket.GetImage();
            Tiket tiket = CredentialsTiket.GetTiket();

            Bitmap bitmap = new Bitmap(barcode);
            Font font = new Font("new courier", 12);
            Font fontHeading = new Font("new courier", 14);
            float tinggiFont = font.GetHeight(e.Graphics);
            float tinggiFontHeading = fontHeading.GetHeight(e.Graphics);
            //float tinggiBarcode = bitmap.Height;
            float mt = 10, mr = 10, mb = 10, ml = 10;
            float y;
            float x = ml;

            int jumBarisSaatIni = 0;
            int maxBarisDalamHalaman = (int)((e.MarginBounds.Height - mt - mb) / tinggiFontHeading);
            string namaFile = $"{tiket.IdInvoice.Id.ToString().PadLeft(3, '0')}{tiket.NoKursi}";
            StreamWriter cetak = new StreamWriter(namaFile);

            cetak.WriteLine("Kelompok");
            cetak.WriteLine("");
            cetak.WriteLine("");
            cetak.WriteLine("Movie");
            cetak.WriteLine($"{tiket.Film.Judul}");
            cetak.WriteLine("");
            cetak.WriteLine("Time and Date");
            cetak.WriteLine($"{tiket.JadwalFilm.Tanggal.ToString("dd-MM-yyyy")}");
            cetak.WriteLine($"{tiket.JadwalFilm.Jam_pemutaran}");
            cetak.WriteLine($"");
            cetak.WriteLine($"");
            cetak.WriteLine("");
            cetak.WriteLine($"Seat");
            cetak.WriteLine($"{tiket.NoKursi}");
            cetak.WriteLine("");
            cetak.WriteLine($"Tiket: Rp. {tiket.Harga}");

            cetak.Close();

            StreamReader bacaCetak = new StreamReader(namaFile);

            /*//! Kelompok
            y = mt + (1 * tinggiFont);
            e.Graphics.DrawString(tiket.Film.Kelompok.Nama, font, Brushes.DarkBlue, x, y);//menulis ke memory
            jumBarisSaatIni++;

            //! Movie
            y = mt + (2 * tinggiFont);
            e.Graphics.DrawString("Movie", fontHeading, Brushes.DarkBlue, x, y);//menulis ke memory
            jumBarisSaatIni++;

            y = mt + (3 * tinggiFont);
            e.Graphics.DrawString(tiket.Film.Judul, font, Brushes.DarkBlue, x, y);//menulis ke memory
            jumBarisSaatIni++;

            y = mt + (4 * tinggiFont);
            e.Graphics.DrawString("Time and Date", fontHeading, Brushes.DarkBlue, x, y);//menulis ke memory
            jumBarisSaatIni++;

            y = mt + (5 * tinggiFont);
            e.Graphics.DrawString(tiket.JadwalFilm.Tanggal.ToString("dd-MM-yyyy"), font, Brushes.DarkBlue, x, y);//menulis ke memory
            jumBarisSaatIni++;

            y = mt + (6 * tinggiFont);
            e.Graphics.DrawString(tiket.JadwalFilm.Jam_pemutaran, font, Brushes.DarkBlue, x, y);//menulis ke memory
            jumBarisSaatIni++;

            y = mt + (7 * tinggiFont);
            e.Graphics.DrawString("Seat", fontHeading, Brushes.DarkBlue, x, y);//menulis ke memory
            jumBarisSaatIni++;

            y = mt + (8 * tinggiFont);
            e.Graphics.DrawString(tiket.NoKursi, font, Brushes.DarkBlue, x, y);//menulis ke memory
            jumBarisSaatIni++;

            y = mt + (9 * tinggiFont);
            e.Graphics.DrawString($"Tiket: Rp. {tiket.Harga}", font, Brushes.DarkBlue, x, y);//menulis ke memory
            jumBarisSaatIni++;

            y = mt + (10 * tinggiFont);
            e.Graphics.DrawString(tiket.Film.Kelompok.Nama, font, Brushes.DarkBlue, x, y);//menulis ke memory
            jumBarisSaatIni++;

            y = mt + (11 * tinggiFont);
            e.Graphics.DrawString(tiket.Film.Kelompok.Nama, font, Brushes.DarkBlue, x, y);//menulis ke memory
            jumBarisSaatIni++;*/
            String textCetak = bacaCetak.ReadLine();//mengambil 1 baris isi filetext
            while (jumBarisSaatIni < maxBarisDalamHalaman && textCetak != null)
            {
                y = mt + (jumBarisSaatIni * tinggiFont);
                e.Graphics.DrawString(textCetak, font, Brushes.DarkBlue, x, y);//menulis ke memory
                jumBarisSaatIni++;
                textCetak = bacaCetak.ReadLine();
            }


            //! Barcode
            e.Graphics.DrawImage(bitmap, x, mt + (jumBarisSaatIni * tinggiFont));

            bitmap.Dispose();

        }
        #endregion

    }
}
