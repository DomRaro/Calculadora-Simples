using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("-------------");
            int res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtrair(); break;
                case 3: Multiplicar(); break;
                case 4: Dividir(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("A soma dos valores é igual a " + (v1 + v2));
            Console.ReadLine();
            Menu();
        }

        static void Subtrair()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.Write("A subtração dos valores é igual a: " + (v1 - v2));
            Console.ReadLine();
            Menu();
        }

        static void Multiplicar()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.Write("A multiplicação dos valores é igual a: " + (v1 * v2));
            Console.ReadLine();
            Menu();
        }

        static void Dividir()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.Write("A divisão dos valores é igual a: " + (v1 / v2));
            Console.ReadLine();
            Menu();

        }

    }
}