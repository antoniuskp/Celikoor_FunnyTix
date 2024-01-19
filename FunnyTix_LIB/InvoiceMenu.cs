using MySql.Data.MySqlClient;
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
    public class InvoiceMenu
    {
        private int id;
        private DateTime tanggal;
        private double grand_total;
        private Konsumen konsumen;
        private Pegawai kasir;
        private string status;
        private List<DetailPesanan> listDetailPesanan;

        public InvoiceMenu()
        {
            this.Id = 0;
            this.Tanggal = DateTime.Now;
            this.Grand_total = 0;
            this.Konsumen = new Konsumen();
            this.Kasir = new Pegawai();
            this.Status = "PENDING";
            this.ListDetailPesanan = new List<DetailPesanan>();
            
        }
        public InvoiceMenu(int id, DateTime tanggal, double grand_total, Konsumen konsumen, Pegawai kasir, string status)
        {
            this.Id = id;
            this.Tanggal = tanggal;
            this.Grand_total = grand_total;
            this.Konsumen = konsumen;
            this.Kasir = kasir;
            this.Status = status;
            this.ListDetailPesanan = new List<DetailPesanan>();

        }

        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public double Grand_total { get => grand_total; set => grand_total = value; }
        public Konsumen Konsumen { get => konsumen; set => konsumen = value; }
        public Pegawai Kasir { get => kasir; set => kasir = value; }
        public string Status { get => status; set => status = value; }
        internal List<DetailPesanan> ListDetailPesanan { get => listDetailPesanan; set => listDetailPesanan = value; }

        #region METHOD

        public static void CetakNota(InvoiceMenu im)
        {
            string nama = "InvoicesMenu_" + im.Id;
            StreamWriter NamaFile = new StreamWriter(nama);
            //List < DetailJual> listCetak = this.ListItem;
            NamaFile.WriteLine($"FunnyTix");
            NamaFile.WriteLine("-------------------");
            NamaFile.WriteLine("NOTA JUAL " + im.Id);
            NamaFile.WriteLine("");
            NamaFile.WriteLine("Tanggal " + im.Tanggal.ToString("dd-MM-yyyy"));
            NamaFile.WriteLine("Konnsumen " + im.Konsumen.Nama);
            NamaFile.WriteLine("Kasir " + im.Kasir.Nama);
            NamaFile.WriteLine("-------------------");
            //NamaFile.WriteLine("Item           Qty  Sub total");
            NamaFile.Write("Item".PadRight(15, ' '));
            NamaFile.Write("Qty".PadRight(5, ' '));
            NamaFile.Write("Sub Total".PadRight(8, ' '));
            NamaFile.WriteLine("");

            string kode = im.Id.ToString();
            List<DetailPesanan> listPesanan = InvoiceMenu.BacaDetailPesanan(kode);

            //Memindah listCetak ke filetext
            double total = 0;
            for (int i = 0; i < listPesanan.Count; i++)
            {
                double subtotal = listPesanan[i].Jumlah * listPesanan[i].Harga;
                total += subtotal;
                string barang = listPesanan[i].Makanan.Nama.PadRight(15, ' ');
                string jumlah = listPesanan[i].Jumlah.ToString().PadLeft(3, ' ');
                string nilai = subtotal.ToString().PadLeft(8, ' ');

                NamaFile.WriteLine($"{barang} {jumlah} {nilai}");
            }
            NamaFile.WriteLine("-------------------");
            NamaFile.WriteLine($"Total Rp " + total.ToString());
            NamaFile.WriteLine("-------------------");
            NamaFile.WriteLine($"Dicetak oleh " + im.Kasir.Nama);
            NamaFile.WriteLine($"Dicetak tanggal " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
            NamaFile.WriteLine("-------------------");
            NamaFile.WriteLine($"");
            NamaFile.Close();

            CustomPrint p = new CustomPrint(new System.Drawing.Font("courier new", 12), nama);
            p.KirimPrinter();

        }
        public static string GenerateNota()
        {
            string notaBaru = "";
            string query = "SELECT * FROM invoices_makanans order by id desc limit 1;";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            if(hasil.Read() == true)
            {
                string noAkhir = hasil.GetValue(0).ToString();
                int noNotaBaru = int.Parse(noAkhir) + 1;
                notaBaru = noNotaBaru.ToString();
            }
            return notaBaru;
        }

        public static InvoiceMenu CariInvoice (string filter, string value)
        {
            string query = $"SELECT * FROM invoices_makanans WHERE {filter} = '{value}';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            if (hasil.Read() == true)
            {
                InvoiceMenu invoice = new InvoiceMenu();
                invoice.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                invoice.Grand_total = double.Parse(hasil.GetValue(2).ToString());
                invoice.Konsumen = Konsumen.BacaData("Id", hasil.GetValue(3).ToString())[0];
                invoice.Kasir = Pegawai.BacaData("Id", hasil.GetValue(4).ToString())[0];

                invoice.Id = int.Parse(hasil.GetValue(0).ToString());

                if (invoice.Kasir != null)
                {
                    invoice.Status = "TERBAYAR";
                }
                return invoice;
            }
            return null;
        }

        public static List<DetailPesanan> BacaDetailPesanan(string id)
        {
            string query = $"SELECT * FROM `detail_pesanans` ds WHERE ds.invoices_makanans_id = '{id}';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);

            List<DetailPesanan> listData = new List<DetailPesanan>();
            while(hasil.Read() == true)
            {
                DetailPesanan ds = new DetailPesanan();
                ds.Jumlah = int.Parse(hasil.GetValue(0).ToString());
                ds.Harga = double.Parse(hasil.GetValue(1).ToString());
                int kode = int.Parse(hasil.GetValue(5).ToString());
                ds.Makanan = Makanan.CariMakanan(kode);
                listData.Add(ds);
            }
            return listData;
        }

        public static List<InvoiceMenu> BacaData(string filter = "", string value = "", Konsumen k = null)
        {
            string query = "SELECT * FROM invoices_makanans;";
            if (value != "" && k == null)
            {
                query = $"SELECT * FROM invoices_makanans where {filter} like '%{value}%';";
            }
            else if (filter == "tanggal" && value != "" && k != null)
            {
                query = $"SELECT * FROM invoices_makanans WHERE tanggal LIKE '{value}%' AND konsumens_id = '{k.ID}';";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(query);
            List<InvoiceMenu> listInvoiceMenu = new List<InvoiceMenu>();

            while (hasil.Read() == true)
            {
                InvoiceMenu invoice = new InvoiceMenu();
                invoice.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                invoice.Grand_total = double.Parse(hasil.GetValue(2).ToString());
                invoice.Konsumen = Konsumen.BacaData("Id", hasil.GetValue(3).ToString())[0];
                invoice.Kasir = Pegawai.BacaData("Id", hasil.GetValue(4).ToString())[0];

                invoice.Id = int.Parse(hasil.GetValue(0).ToString());

                if(invoice.Kasir != null)
                {
                    invoice.Status = "TERBAYAR";
                }
                listInvoiceMenu.Add(invoice);
            }
            return listInvoiceMenu;
        }

        public void TambahDetail(int jumlah, MakananCinemas mc)
        {
            DetailPesanan dp = new DetailPesanan();
            dp.Jumlah = jumlah;
            dp.Harga = mc.Harga;
            dp.Cinema = mc.Cinema;
            dp.Makanan= mc.Makanan_;
            this.ListDetailPesanan.Add(dp);
        }
        public static void TambahData(InvoiceMenu im)
        {
            string perintah = $"INSERT INTO invoices_makanans (id, tanggal, grand_total, konsumens_id) VALUES ('{im.Id}', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{im.Grand_total}', '{im.Konsumen.ID}');";
            Koneksi.JalankanPerintahNonQuery(perintah);  //! Kirim ke command

            //! 2. Loop item ke db
            //Ini perlu dilakukan looping karena pertama memanggil method TambagDetail yang memasukkan data ke dalam listItem
            //Untuk memasukkan data ke database detail jual, maka perlu dilakukan looping dari listItem
            for (int i = 0; i < im.ListDetailPesanan.Count; i++)
            {
                perintah = $"INSERT INTO `funnytix`.`detail_pesanans` (`harga`, `jumlah`, `invoices_makanans_id`, `cinemas_id`, `makanans_id`) " +
                    $"VALUES ('{im.ListDetailPesanan[i].Harga}', '{im.ListDetailPesanan[i].Jumlah}', '{im.Id}', '{im.ListDetailPesanan[i].Cinema.ID}', '{im.ListDetailPesanan[i].Makanan.Id}');";

                Koneksi.JalankanPerintahNonQuery(perintah);
            }
        }


        
        #endregion
    }
}
