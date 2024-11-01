using System;

class Program
{
    public static void DecimalABinario(int num_decimal)
    {
        string binario = "";

        while (num_decimal > 0)
        {
            binario = (num_decimal % 2) + binario;
            num_decimal /= 2;
        }

        Console.WriteLine("Binario: " + binario);
    }

    public static void BinarioADecimal(string binario)
    {
        int num_decimal = 0;

        for (int i = 0; i < binario.Length; i++)
        {
            num_decimal *= 2;

            if (binario[i] == '1')
            {
                num_decimal += 1;
            }
        }

        Console.WriteLine("Decimal: " + num_decimal);
    }

    static void Main(string[] args)
    {
        Console.Write("Convertir decimal a binario (ejemplo con 10): ");
        DecimalABinario(10);

        Console.Write("Convertir binario a decimal (ejemplo con '1010'): ");
        BinarioADecimal("1010"); 
    }
}
