using System;

class Program
{
    public static double AreaDeUnCirculo(double radio)
    {
        double pi = 3.14;
        return pi * radio * radio; 
    }

    public static double VolumenDeCilindro(double radio, double altura)
    {
        double areaBase = AreaDeUnCirculo(radio);
        return areaBase * altura; 
    }

    static void Main(string[] args)
    {
        Console.Write("radio del circulo: ");
        double radio = double.Parse(Console.ReadLine());

        double area = AreaDeUnCirculo(radio);
        Console.WriteLine("area del círculo: " + area);

        Console.Write("altura del cilindro: ");
        double altura = double.Parse(Console.ReadLine());

        double volumen = VolumenDeCilindro(radio, altura);
        Console.WriteLine("volumen del cilindro: " + volumen);
    }
}
