using System;

namespace Aula9Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadoramedia casio = new Calculadoramedia();

            Console.WriteLine("Digite o primeiro numero:");
            int numero1 = Int16.Parse (Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            int numero2 = Int16.Parse (Console.ReadLine());

            Console.WriteLine("Digite  \n 1 para dividir \n 2 para multiplicar  \n 3 para subtrair \n 4 para somar   \n 5 para obter a media");
            string operação = Console.ReadLine();
            Console.Clear();


            switch (operação)
            {
                case "2": Console.WriteLine($"{numero1} X {numero2} = {casio.Multiplicar(numero1, numero2)}");
                break;

                case "3": Console.WriteLine($"{numero1} - {numero2} = {casio.Subtrair(numero1, numero2)}");
                break;

                case "1": Console.WriteLine($"{numero1} / {numero2} = {casio.Dividir(numero1, numero2)}");
                break;

                case "4": Console.WriteLine($"{numero1} + {numero2} = {casio.Somar(numero1, numero2)}");
                break;

                case "5": Console.WriteLine($"{numero1} + {numero2} / 2 = {casio.Media(numero1, numero2)}");
                break;

                default: Console.WriteLine("Digite valores validos!");
                break;
            }

        }
    }
}
