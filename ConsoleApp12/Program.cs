using System;

class Fraction
{
    public Fraction(int suret_, int mexrec_)
    {
        suret = suret_;
        mexrec = mexrec_;
    }

    public int suret { get; set; }
    public int mexrec { get; set; }

    public Fraction toplama(Fraction other)
    {
        if (mexrec == other.mexrec)
        {
            suret += other.suret;
            return new Fraction(suret, mexrec);
        }
        else
        {
            int newSuret = suret * other.mexrec + other.suret * mexrec;
            int newMexrec = mexrec * other.mexrec;
            return new Fraction(newSuret, newMexrec);
        }
    }

    public Fraction cixma(Fraction other)
    {
        if (mexrec == other.mexrec)
        {
            suret -= other.suret;
            return new Fraction(suret, mexrec);
        }
        else
        {
            int newSuret = suret * other.mexrec - other.suret * mexrec;
            int newMexrec = mexrec * other.mexrec;
            return new Fraction(newSuret, newMexrec);
        }
    }

    public Fraction vurma(Fraction other)
    {
        int newSuret = suret * other.suret;
        int newMexrec = mexrec * other.mexrec;
        return new Fraction(newSuret, newMexrec);
    }

    public Fraction bolme(Fraction other)
    {
        int newSuret = suret * other.mexrec;
        int newMexrec = mexrec * other.suret;
        return new Fraction(newSuret, newMexrec);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(2, 5);
            Fraction fraction2 = new Fraction(4, 3);

            Fraction sum = fraction1.toplama(fraction2);
            Console.WriteLine($"Toplama: {sum.suret}/{sum.mexrec}");

            Fraction difference = fraction1.cixma(fraction2);
            Console.WriteLine($"Cixarma: {difference.suret}/{difference.mexrec}");

            Fraction product = fraction1.vurma(fraction2);
            Console.WriteLine($"Vurma: {product.suret}/{product.mexrec}");

            Fraction quotient = fraction1.bolme(fraction2);
            Console.WriteLine($"Bolme: {quotient.suret}/{quotient.mexrec}");
        }
    }
}