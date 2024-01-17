using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyTix_LIB
{
    public static class CredentialsTiket
    {
        public static Image BrcImage;
        public static Tiket Tiket_;

        public static Image GetImage()
        {
            return BrcImage;
        }

        public static Tiket GetTiket()
        {
            return Tiket_;
        }
    }
}
