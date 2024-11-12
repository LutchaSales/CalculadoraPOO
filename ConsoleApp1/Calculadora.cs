using System;


namespace ConsoleApp1
{
    internal class Calculadora
    {
        public static void Iniciar()
        {
            bool continua = true;
            while (continua)
            {

                Console.WriteLine("Qual tipo de Calculo você deseja? \n" +
                    "1 = SOMA \n" +
                    "2 = SUBTRAÇÃO \n" +
                    "3 = DIVISÃO \n" +
                    "4 = MULTIPLICAÇÃO \n" +
                    "5 = PORCENTAGEM\n" +
                    "6 = JUROS");
                string tipoCalculo = Console.ReadLine();

                switch (tipoCalculo) 
                {
                    case "1": Somar(); break;
                    case "2": Subtrair(); break;
                    case "3": Dividir(); break;
                    case "4": Multiplicar(); break;
                    case "5": Porcentagem(); break;
                    case "6": Juros(); break;
                    default: Console.WriteLine("Valor Incorreto!"); break;
                }

                

                Console.WriteLine();

                Console.WriteLine("Deseja Continuar...? (S/N)");
                string desejaContinuar = Console.ReadLine();

                if (desejaContinuar == "N")
                {
                    continua = false;
                }

            }
        }

        public static void Somar()
        {
            Console.WriteLine("Você entrou no método somar!");
            Console.WriteLine();
            Console.WriteLine("Digite o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} é igual a : {num1 + num2}");
        }
        public static void Subtrair()
        {
            Console.WriteLine("Entrou no método Subtrair!");
            Console.WriteLine();
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} - {num2} é igual a : {num1 - num2}");

        }

        public static void Dividir() 
        {
            Console.WriteLine("Entrou no método Dividir!");
            Console.WriteLine();
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} Dividido por {num2} é igual a : {num1 / num2} \n" +
                $"E o resto dessa divisão é igual a : {num1 % num2}");
        }

        public static void Multiplicar() 
        {
            Console.WriteLine("Entrou no método Multiplicar!");
            Console.WriteLine();
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} * {num2} é igual a : {num1 * num2}");
        }

        public static void Porcentagem() 
        {
            Console.WriteLine("Entrou no método Porcentagem!");
            Console.WriteLine();
            Console.WriteLine("Informe o número: ");
            double num1 = double.Parse(Console.ReadLine() );

            Console.WriteLine("Informe o valor da PORCENTAGEM: ");
            double num2 = double.Parse(Console.ReadLine());

            // Calculo de desconto do valor pela sua porcentagem 
            double resultado = num1 - (num1 * (num2 / 100));

            Console.WriteLine($"{num2} de {num1} é igual a {resultado}");
        }

        public static void Juros()
        {
            Console.WriteLine("Entrou no método Juros!");
            Console.WriteLine();
            Console.WriteLine("Informe o Valor: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do Juros: ");
            double num2 = double.Parse(Console.ReadLine());

            // Calculo do valor de juros 
            double resultado = num1 + (num1 * (num2 / 100));

            Console.WriteLine($"{num2} de {num1} é igual a {resultado}");
        }
    }
}