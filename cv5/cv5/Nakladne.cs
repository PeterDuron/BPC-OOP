using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    public class Nakladne : Auto
    {
        public Nakladne() : base(500, TypPaliva.Nafta)
        {
            MaxNaklad = 15000;
            MaxOsoby = 2;
        }

        public override string ToString()
        {
            return $"Nakladné auto: Stav nádrže: {StavNadrze}L, Prepravovaný náklad: {PrepravovanyNaklad}kg, Pocet osôb: {PrepravovaneOsoby}";
        }

    }
}

