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

        public MakananCinemas()
        {
            this.Makanan_ = new Makanan();
            this.Harga = 0.0;
        }

        public static List<MakananCinemas> BacaData(Cinema cinema)
        {
            //string cmd = $"SELECT distinct m.* FROM makanans as m INNER JOIN makanans_cinemas as mc WHERE m.id in (SELECT mc.makanans_id from makanans_cinemas as mc where mc.cinemas_id = {cinema.ID})";

            string cmd = $"SELECT mc.makanans_id, mc.harga FROM makanans_cinemas as mc WHERE mc.cinemas_id = '{cinema.ID}'";
            var res = Koneksi.JalankanPerintahSelect(cmd);

            var lst = new List<MakananCinemas>();

            while (res.Read())
            {
                MakananCinemas mc = new MakananCinemas();
                mc.Makanan_ = Makanan.CariMakanan(res.GetInt32(0));
                mc.Harga = res.GetDouble(1);

                lst.Add(mc);
            }

            return lst;
        }
    }
}
