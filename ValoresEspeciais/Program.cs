using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($"sbyte: Min = {sbyte.MinValue}, Max = {sbyte.MaxValue}");
            Console.WriteLine($"byte: Min = {byte.MinValue}, Max = {byte.MaxValue}");
            Console.WriteLine($"short: Min = {short.MinValue}, Max = {short.MaxValue}");
            Console.WriteLine($"ushort: Min = {ushort.MinValue}, Max = {ushort.MaxValue}");
            Console.WriteLine($"int: Min = {int.MinValue}, Max = {int.MaxValue}");
            Console.WriteLine($"uint: Min = {uint.MinValue}, Max = {uint.MaxValue}");
            Console.WriteLine($"long: Min = {long.MinValue}, Max = {long.MaxValue}");
            Console.WriteLine($"ulong: Min = {ulong.MinValue}, Max = {ulong.MaxValue}");
            Console.WriteLine($"float: Min = {float.MinValue}, Max = {float.MaxValue}");
            Console.WriteLine($"double: Min = {double.MinValue}, Max = {double.MaxValue}");
            Console.WriteLine($"decimal: Min = {decimal.MinValue}, Max = {decimal.MaxValue}");

            Console.WriteLine($"\nFloat: +Infinity = {float.PositiveInfinity}");
            Console.WriteLine($"Float: -Infinity = {float.NegativeInfinity}");
            Console.WriteLine($"Float: NaN = {float.NaN}");

            Console.WriteLine($"\nDouble: +Infinity = {double.PositiveInfinity}");
            Console.WriteLine($"Double: -Infinity = {double.NegativeInfinity}");
            Console.WriteLine($"Double: NaN = {double.NaN}");

            uint u = uint.MaxValue;
            Console.WriteLine($"\nValor inicial uint: {u}");
            Console.WriteLine($"Valor overflow em uint: {++u}");

            float f = float.MaxValue;
            Console.WriteLine($"\nValor inicial float: {f}");
            Console.WriteLine($"Valor overflow * 2f: {f*2f}");
            Console.WriteLine($"Valor overflow + 1e38f: {f + + 1e38f}");

        }
    }
}
