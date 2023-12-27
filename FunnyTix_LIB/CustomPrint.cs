using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace FunnyTix_LIB
{
    public class CustomPrint
    {
        private Font tipeFont;
        private StreamReader fileCetak;
        private float marginAtas, marginBawah, marginKanan, marginKiri;

        public Font TipeFont { get => tipeFont; set => tipeFont = value; }
        public StreamReader FileCetak { get => fileCetak; set => fileCetak = value; }
        public float MarginAtas { get => marginAtas; set => marginAtas = value; }
        public float MarginBawah { get => marginBawah; set => marginBawah = value; }
        public float MarginKanan { get => marginKanan; set => marginKanan = value; }
        public float MarginKiri { get => marginKiri; set => marginKiri = value; }

        public CustomPrint(Font pFont, string pNamaFile)
        {
            this.TipeFont = pFont;
            this.FileCetak = new StreamReader(pNamaFile);
            this.MarginAtas = 30;
            this.MarginBawah = 30;
            this.MarginKanan = 15;
            this.MarginKiri = 15;
        }

        public void Cetak(object sender, PrintPageEventArgs e)
        {
            float tinggiFont = TipeFont.GetHeight(e.Graphics);
            float y;
            float x = MarginKiri;
            int jumBarisSaatIni = 0;
            int maxBarisDalamHalaman = (int)((e.MarginBounds.Height - MarginAtas - MarginBawah) / tinggiFont); //e.MarginBounds.Height = Tinggi Kertas

            string textCetak = FileCetak.ReadLine();//mengambil 1 baris isi filetext
            while (jumBarisSaatIni < maxBarisDalamHalaman && textCetak != null)
            {
                y = MarginAtas + (jumBarisSaatIni * tinggiFont);
                e.Graphics.DrawString(textCetak, TipeFont, Brushes.Black, x, y); //menulis ke memory
                jumBarisSaatIni++;
                textCetak = FileCetak.ReadLine();
            }
            if (textCetak != null) //jika isi filetext belum abis namun halaman sudah penuh, pindah ke halaman berikutnya
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        public void KirimPrinter()
        {
            //proses mencetak ke printer
            PrintDocument p = new PrintDocument();
            p.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            //menulis ke memory untuk tiap halaman
            p.PrintPage += new PrintPageEventHandler(Cetak);
            p.Print();

            FileCetak.Close();
        }
    }
}

