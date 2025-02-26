using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class TestComplex
{
    private const double Epsilon = 1E-6;

    public static void Test(Complex skutocna, Complex ocakavana, string nazov)
    {
        
        double realDifference = Math.Abs(skutocna.Realna - ocakavana.Realna);
        double imagDifference = Math.Abs(skutocna.Imaginarna - ocakavana.Imaginarna);

        
        if (realDifference < Epsilon && imagDifference < Epsilon)
        {
            Console.WriteLine($"Test {0}: OK", nazov);
        }
        else
        {
            Console.WriteLine($"Test {0}: Chyba", nazov);
            Console.WriteLine($"  Očakávaná hodnota: {skutocna.Realna} + {skutocna.Imaginarna}j");
            Console.WriteLine($"  Skutočná hodnota: {ocakavana.Realna} + {ocakavana.Imaginarna}j");
        }
    }
}



