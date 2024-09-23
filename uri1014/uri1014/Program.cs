﻿using System;
using System.Globalization;

namespace uri1014 {
    internal class Program {
        static void Main(string[] args) {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double consumo = x / y;
            Console.WriteLine(consumo.ToString("F3") + CultureInfo.InvariantCulture + " km/l");
        }
    }
}
