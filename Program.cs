using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero1, numero2;
            String operador;

            Console.Write("Calculadora de Console C#\n");

            Console.Write("Insira um número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a operação: ");
            operador = Console.ReadLine();

            Console.Write("Insira o segundo valor: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            switch (operador)
            {
                case "+":
                    Console.WriteLine($"Total: {numero1} + {numero2} = " + (numero1 + numero2));
                    break;

                case "-":
                    Console.WriteLine($"Total: {numero1} - {numero2} = " + (numero1 - numero2));
                    break;
                case "*":
                    Console.WriteLine($"Total: {numero1} * {numero2} = " + (numero1 * numero2));
                    break;
                case "/":
                    Console.WriteLine($"Total: {numero1} / {numero2} = " + (numero1 / numero2));
                    break;
                default:
                    Console.WriteLine("Valor inválido, tente novamente...");
                break;
            }

            Console.WriteLine("Aperte ENTER para fechar");
            Console.ReadKey();
        }
    }
}
