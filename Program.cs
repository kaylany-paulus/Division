using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numerator, denominator;
            bool validNumerator;
        
            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("\nOlá! Esse programa calcula uma divisão para você.");
            Console.ResetColor();
            Console.ForegroundColor=ConsoleColor.Cyan;
            Console.Write("\n\nDigite o numerador.....: ");
            validNumerator=Decimal.TryParse(Console.ReadLine(), out numerator);

                if (!validNumerator)
                {
                    Console.Clear();
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("\n\nO VALOR DIGITADO NÃO CORRESPONDE A UM VALOR NUMÉRICO!\n");
                    Console.ResetColor();
                    Environment.Exit(-1);
                }

            Console.Write("Digite o denominador...: ");
            validNumerator=Decimal.TryParse(Console.ReadLine(), out denominator);

                if (!validNumerator)
                {
                    Console.Clear();
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("\n\nO VALOR DIGITADO NÃO CORRESPONDE A UM VALOR NUMÉRICO!\n");
                    Console.ResetColor();
                    Environment.Exit(-1);
                }
                
                else if (denominator == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("\n\nNÃO É POSSÍVEL DIVIDIR POR ZERO!\n ");
                    Console.ResetColor();
                    Environment.Exit(-1);
                }


            
            decimal divisionResult= numerator / denominator;
            Console.ResetColor();
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine($"\n{numerator} dividido por {denominator} é {divisionResult}!");

            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("\n\nOBRIGADA PELO ACESSO!\n");
            Console.ResetColor();
            Environment.Exit(-1);

        }
    }
}
