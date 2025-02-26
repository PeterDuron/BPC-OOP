using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Complex
{
    public double Realna;
    public double Imaginarna;

    public Complex(double realna = 0.0, double imaginarna = 0.0)
    {
        Realna = realna;
        Imaginarna = imaginarna;
    }

    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Realna + b.Realna, a.Imaginarna + b.Imaginarna);
    }

    public static Complex operator -(Complex a, Complex b)
    {
        return new Complex(a.Realna - b.Realna, a.Imaginarna - b.Imaginarna);
    }

    public static Complex operator *(Complex a, Complex b)
    {
        double real = a.Realna * b.Realna - a.Imaginarna * b.Imaginarna;
        double imag = a.Realna * b.Imaginarna + a.Imaginarna * b.Realna;
        return new Complex(real, imag);
    }

    public static Complex operator /(Complex a, Complex b)
    {
        double denominator = b.Realna * b.Realna + b.Imaginarna * b.Imaginarna;
        if (denominator == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        double real = (a.Realna * b.Realna + a.Imaginarna * b.Imaginarna) / denominator;
        double imag = (a.Imaginarna * b.Realna - a.Realna * b.Imaginarna) / denominator;

        return new Complex(real, imag);
    }

    public static bool operator ==(Complex a, Complex b)
    {
        return (a.Realna == b.Realna) && (a.Imaginarna == b.Imaginarna);
    }

    public static bool operator !=(Complex a, Complex b)
    {
        return !(a == b);
    }

    public override string ToString()
    {
        if (Imaginarna < 0)
        {
            return string.Format("{0}-{1}j", Realna, -Imaginarna);
        }
        else
        {
            return string.Format("{0}+{1}j", Realna, Imaginarna);
        }
    }

    public Complex Zdruzene()
    {
        return new Complex(Realna, -Imaginarna);
    }

    public double Modul()
    {
        return Math.Sqrt(Realna*Realna+Imaginarna*Imaginarna);
    }

    public double Argument()
    {
        return Math.Atan2(Imaginarna,Realna);
    }
}


