﻿using System;

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
