using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.InteropServices;

namespace FunnyTix_LIB
{
    public class GenerateBarcodeMenu
    {
        public GenerateBarcodeMenu()
        { }
        public void Print(InvoiceMenu invoice)
        {

            //! Make Barcode based on invoice+noKursi
            string kodeTiket = invoice.Tanggal.ToString("yyyyMMdd")+invoice.Id.ToString().PadLeft(3, '0');
            namafile = kodeTiket;
            Zen.Barcode.BarcodeDraw brc = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;

            Image brcImage = brc.Draw(kodeTiket, 70);
            CredentialsTiket.BrcImage = brcImage;

            PrintDocument printer = new PrintDocument();
            printer.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printer.PrintPage += new PrintPageEventHandler(PrintBarcode);
            printer.Print();
        }
        string namafile;
        private void PrintBarcode(object sender, PrintPageEventArgs e)
        {
            
            Image barcode = CredentialsTiket.GetImage();

            Bitmap bitmap = new Bitmap(barcode);
            Font font = new Font("new courier", 12);
            Font fontHeading = new Font("new courier", 14);
            float tinggiFont = font.GetHeight(e.Graphics);
            float tinggiFontHeading = fontHeading.GetHeight(e.Graphics);
            float mt = 10, mr = 10, mb = 10, ml = 10;
            float y;
            float x = ml;

            int jumBarisSaatIni = 0;
            int maxBarisDalamHalaman = (int)((e.MarginBounds.Height - mt - mb) / tinggiFontHeading);
            string namaFile = $"{namafile}";
            //! Barcode
            e.Graphics.DrawImage(bitmap, x, mt + (jumBarisSaatIni * tinggiFont));
            e.Graphics.DrawString(namaFile, font, Brushes.Black, x + 5, mt + ((jumBarisSaatIni + 4) * tinggiFont));
            bitmap.Dispose();

        }
    }
}
