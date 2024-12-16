using System;

namespace PairOuImpair // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Est pair...? Est impair...? ---");
            Console.Write("Combien de nombres contiendra le tableau ? : ");
            int userInput = int.Parse(Console.ReadLine());
            int[] tableau = new int[userInput];
            Console.WriteLine("Affectation automatique des valeurs...");

            for (int i = 0; i < tableau.Length; i++)
            {
                Random random = new Random();
            }

        }
    }
}