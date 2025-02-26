using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class main
{
    public static void Main()
    {
        TestComplex.Test(new Complex(2.1, 3.8) + new Complex(1, 4), new Complex(3.1, 7.8), "test +");
        TestComplex.Test(new Complex(2.1, 3.8) - new Complex(1, 4), new Complex(1.1, -0.2), "test -");
        TestComplex.Test(new Complex(2.1, 3.8) / new Complex(1, 4), new Complex(1.0176470588235293, -0.2705882352941177), "test *");
        TestComplex.Test(new Complex(2.1, 3.8) * new Complex(1, 4), new Complex(3.1, 7.8), "test /");
    }
} 

