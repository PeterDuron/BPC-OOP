using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    public abstract class Auto
    {
        public enum TypPaliva { Benzin, Nafta };

        public double VelkostNadrze { get; private set; }
        public double StavNadrze { get; private set; }
        public TypPaliva Palivo { get; private set; }
        public double PrepravovanyNaklad { get; private set; }
        public int PrepravovaneOsoby { get; private set; }

        protected double MaxNaklad { get; set; }
        protected int MaxOsoby { get; set; }

        public Autoradio Radio { get; private set; }

        public Auto(double velkostNadrze, TypPaliva palivo)
        {
            VelkostNadrze = velkostNadrze;
            Palivo = palivo;
            StavNadrze = 0;
            Radio = new Autoradio();
        }

        public void Natankuj(TypPaliva typPaliva, double mnozstvi)
        {
            if (typPaliva != Palivo)
                throw new InvalidOperationException("Nevhodný typ paliva!");

            if (StavNadrze + mnozstvi > VelkostNadrze)
                throw new InvalidOperationException("Pretečená nádrž!");

            StavNadrze += mnozstvi;
        }

        public void NastavPrepravovanyNaklad(double naklad)
        {
            if (naklad > MaxNaklad)
                throw new InvalidOperationException("Vozidlo je preťažené");
            PrepravovanyNaklad = naklad;
        }

        public void NastavPrepravovaneOsoby(int osoby)
        {
            if (osoby > MaxOsoby)
                throw new InvalidOperationException("Vo vozidle nie je dostatok miest na sedenie");
            PrepravovaneOsoby = osoby;
        }

        

    }
}
