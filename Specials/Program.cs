using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sby = sbyte.MaxValue;
            sbyte sb = sbyte.MinValue;
            Console.WriteLine($"---SBYTE---\nMáximo: {sby}\nMinímo: {sb}");

            double doub = double.MaxValue;
            double db = double.MinValue;
            Console.WriteLine($"\n---DOUBLE---\nMáximo: {doub}\nMinímo: {db}");
            Console.WriteLine($"OverFlow: {doub = double.MaxValue+1}"+
                                $" ou {doub = 2 * double.MaxValue}");
            double db1, db2;
            db1 = db2 = 10000.0;
            Console.WriteLine($"UnderFlow: {db1 == db2 + 0.0001f}"); 

            ulong ulo = ulong.MaxValue;
            ulong ul = ulong.MinValue;
            Console.WriteLine($"\n---ULONG---\nMáximo: {ulo}\nMinímo: {ul}");

            int inte = int.MaxValue;
            int it = int.MinValue;
            Console.WriteLine($"\n---INT---\nMáximo: {inte}\nMinímo: {it}");
            Console.WriteLine($"OverFlow: {(int) (inte+1)}");

            float flo = float.MaxValue;
            float fl = float.MinValue;
            Console.WriteLine($"\n---FLOAT---\nMáximo: {flo}\nMinímo: {fl}");
            Console.WriteLine($"OverFlow: {flo = float.MaxValue+1}"+
                                $" ou {flo = 2 * float.MaxValue}");  
            float flo1, flo2;
            flo1 = flo2 = 10000.0f;
            Console.WriteLine($"UnderFlow: {flo1 == flo2 + 0.0001f}");

            short sho = short.MaxValue;
            short sh = short.MinValue;            
            Console.WriteLine($"\n---SHORT---\nMáximo: {sho}\nMinímo: {sh}");
            
            char cha = char.MaxValue;
            char ch = char.MinValue;
            Console.WriteLine($"\n---CHAR---\nMáximo: {cha}\nMinímo: {ch}");

            decimal dec = decimal.MaxValue;
            decimal de = decimal.MinValue;
            Console.WriteLine($"\n---DECIMAL---\nMáximo: {dec}\nMinímo: {de}");

            double neg = double.NegativeInfinity;
            double posit = double.PositiveInfinity;
            float nanf = float.NaN;
            double nand = double.PositiveInfinity/double.PositiveInfinity;
            Console.WriteLine($"\n---ESPECIAIS---\nInfinito Negativo: {neg}"+
                                $"\nInfinito Positivo: {posit}"+
                                $"\nFloat NAN: {nanf}\nDouble NAN: {nand}");



        }
    }
}
