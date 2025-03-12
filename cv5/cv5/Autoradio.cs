using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    public class Autoradio
    {
        private Dictionary<int, double> predvolby = new Dictionary<int, double>();
        public double Kmitocet { get; private set; }
        public bool ZapnuteRadio { get; private set; }

        public void NastavPredvolbu(int poradie, double kmitocet)
        {
            predvolby[poradie] = kmitocet;
        }

        public void PreladNaPredvolbu(int cislo)
        {
            if (predvolby.ContainsKey(cislo))
            {
                Kmitocet = predvolby[cislo];
            }
            else
            {
                throw new Exception("Zadaná predvoľba neexistuje");
            }
        }

        public void ZapniRadio()
        {
            ZapnuteRadio = true;
        }

        public void VypniRadio()
        {
            ZapnuteRadio = false;
        }
    }
}

