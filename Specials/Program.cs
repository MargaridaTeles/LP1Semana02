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

            float flo = float.MaxValue;
            float fl = float.MinValue;
            Console.WriteLine($"\n---FLOAT---\nMáximo: {flo}\nMinímo: {fl}");

            short sho = short.MaxValue;
            short sh = short.MinValue;            
            Console.WriteLine($"\n---SHORT---\nMáximo: {sho}\nMinímo: {sh}");

            decimal dec = decimal.MaxValue;
            decimal de = decimal.MinValue;
            Console.WriteLine($"\n---DECIMAL---\nMáximo: {dec}\nMinímo: {de}");



        }
    }
}
