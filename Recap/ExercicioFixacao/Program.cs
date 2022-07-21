﻿using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string product1 = "computador";
            string product2 = "Mesa de escritório";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double measure = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{product1}, cujo preço é $ {price1}");
            Console.WriteLine($"{product2}, cujo preço é $ {price2:F2} \n");
            Console.WriteLine($"Registro: {age} anos de idade, código {code} e gênero: {gender} \n");
            Console.WriteLine($"Medida com oito casas decimais: {measure:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {measure:F3}");
            Console.WriteLine($"Separador decimal com invariant culture: {measure.ToString("F3", CultureInfo.InvariantCulture)}");


        }
    }
}

