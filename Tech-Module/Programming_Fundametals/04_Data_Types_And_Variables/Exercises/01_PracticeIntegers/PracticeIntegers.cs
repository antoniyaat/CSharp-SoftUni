﻿using System;

namespace _01.Practice_Integers
{
    public class PracticeIntegers
    {
        public static void Main()
        {
            sbyte num1 = sbyte.Parse(Console.ReadLine());
            byte num2 = byte.Parse(Console.ReadLine());
            short num3 = short.Parse(Console.ReadLine());
            ushort num4 = ushort.Parse(Console.ReadLine());
            uint num5 = uint.Parse(Console.ReadLine());
            int num6 = int.Parse(Console.ReadLine());
            long num7 = long.Parse(Console.ReadLine());

            Console.WriteLine($"{num1}\n{num2}\n{num3}\n{num4}\n{num5}\n{num6}\n{num7}\n");
        }
    }
}