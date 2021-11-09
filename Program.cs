using System;
using System.Globalization;

namespace AppExerciciospropostos_Logica02
{
    class Program
    {
        /// <summary>
        /// Exercicios Propostos 02.
        /// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
        /// casas decimais
        /// </summary>
        /// <param name="raio"></param>
        /// <returns></returns>
        public static double CalcularValorDaArea(double raio) 
        {
            double pi = 3.14159;
            double area;
            return area = pi * Math.Pow(raio, 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio de um circulo: ");
            double raio = double.Parse(Console.ReadLine());
            double area = CalcularValorDaArea(raio);
            Console.WriteLine("Area é igual á: {0}", area.ToString("F4",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
