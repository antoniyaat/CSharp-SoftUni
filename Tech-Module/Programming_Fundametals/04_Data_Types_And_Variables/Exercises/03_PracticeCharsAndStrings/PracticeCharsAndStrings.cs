﻿using System;

namespace _03.PracticeCharsAndStrings
{
    public class PracticeCharsAndStrings
    {
        public static void Main()
        {
            string firstLine = Console.ReadLine();
            char secondLine = char.Parse(Console.ReadLine());
            char thirdLine = char.Parse(Console.ReadLine());
            char forthLine = char.Parse(Console.ReadLine());
            string fifthLine = Console.ReadLine();

            Console.WriteLine($"{firstLine}\n{secondLine}\n{thirdLine}\n{forthLine}\n{fifthLine}\n");
        }
    }
}