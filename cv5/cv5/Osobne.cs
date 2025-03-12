using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    public class Osobne : Auto
    {
        public Osobne() : base(50, TypPaliva.Benzin)
        {
            MaxNaklad = 800;
            MaxOsoby = 4;
        }

        public override string ToString()
        {
            string radioInfo = Radio.ZapnuteRadio
            ? $"Rádio zapnuto, naladěno na {Radio.Kmitocet} MHz.": "Rádio vypnuto.";

            return $"Osobné auto: Stav nádrže: {StavNadrze}L, Prepravovaný náklad: {PrepravovanyNaklad}kg, Pocet osôb: {PrepravovaneOsoby}, {radioInfo}";
        }

    }
}
