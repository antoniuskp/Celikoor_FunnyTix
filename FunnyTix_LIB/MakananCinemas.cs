using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyTix_LIB
{
    public class MakananCinemas
    {
        public Makanan Makanan_ { get; set; }
        public double Harga { get; set; }
        public Cinema Cinema { get; set; }

        public MakananCinemas()
        {
            this.Makanan_ = new Makanan();
            this.Harga = 0.0;
            this.Cinema = new Cinema();
        }

        public static List<MakananCinemas> BacaData(Cinema cinema)
        {
            //string cmd = $"SELECT distinct m.* FROM makanans as m INNER JOIN makanans_cinemas as mc WHERE m.id in (SELECT mc.makanans_id from makanans_cinemas as mc where mc.cinemas_id = {cinema.ID})";

            string cmd = $"SELECT * FROM makanans_cinemas as mc WHERE mc.cinemas_id = '{cinema.ID}'";
            var res = Koneksi.JalankanPerintahSelect(cmd);

            var lst = new List<MakananCinemas>();

            while (res.Read())
            {
                MakananCinemas mc = new MakananCinemas();
                mc.Cinema = Cinema.BacaData("id", res.GetValue(0).ToString())[0];
                mc.Makanan_ = Makanan.CariMakanan(res.GetInt32(1));
                mc.Harga = res.GetDouble(2);

                lst.Add(mc);
            }

            return lst;
        }
    }
}
