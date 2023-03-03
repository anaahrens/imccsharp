using System.Globalization;

namespace Exercicio21
{
    internal class Program
    {
        static void Main (string[ ] args)
        {

            Console.WriteLine("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: ", imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso.");
            }
            else if (imc < 24.9) 
            {
                Console.WriteLine("Peso normal.");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine("Sobrepeso.");
            }
            else if (imc < 34.9)
            {
                Console.WriteLine("Obesidade grau 1");
            }
            else if (imc < 39.9)
            {
                Console.WriteLine("Obesidade grau 2");
            }
            else
            {
                Console.WriteLine("Obesidade grau 3");
            }
    }
    }
}