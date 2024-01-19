using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyTix_LIB
{
    public class DetailPesanan
    {
        private int id;
        private int jumlah;
        private double harga;
        private InvoiceMenu invoice;
        private Cinema cinema;
        private Makanan makanan;

        public DetailPesanan(int jumlah, double harga, InvoiceMenu invoice, Cinema cinema, Makanan makanan)
        {
            this.Id = 0;
            this.Jumlah = jumlah;
            this.Harga = harga;
            this.Invoice = invoice;
            this.Cinema = cinema;
            this.Makanan = makanan;
        }
        public DetailPesanan()
        {
            this.Id = 0;
            this.Jumlah = 0;
            this.Harga = 0.0;
            this.Invoice = new InvoiceMenu();
            this.Cinema = new Cinema();
            this.Makanan = new Makanan();
        }

        public int Id { get => id; set => id = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public double Harga { get => harga; set => harga = value; }
        public InvoiceMenu Invoice { get => invoice; set => invoice = value; }
        public Cinema Cinema { get => cinema; set => cinema = value; }
        public Makanan Makanan { get => makanan; set => makanan = value; }
    }
}
