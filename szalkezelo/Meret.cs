using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szalkezelo
{
    class Meret
    {
        private int szelesseg;
        private int magassag;
        private int vastagsag;
        private int atmero;

        public Meret(int szel, int mag, int vas, int atm)
        {
            szelesseg = szel;
            magassag = mag;
            vastagsag = vas;
            atmero = atm;
        }

        public string getNev()
        {
            if (atmero != 0)
                return string.Format("{0}⌀", atmero);

            if (vastagsag != 0)
                return string.Format("{0}x{1}x{2}", szelesseg, magassag, vastagsag);

            return string.Format("{0}x{1}", szelesseg, magassag);
        }

        public int getSzelesseg()
        {
            return szelesseg;
        }

        public int getMagassag()
        {
            return magassag;
        }

        public int getVastagsag()
        {
            return vastagsag;
        }

        public int getAtmero()
        {
            return atmero;
        }
    }
}
