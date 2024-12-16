using System;

namespace PairOuImpair // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Est pair...? Est impair...? ---");
            Console.Write("Combien de nombres contiendra le tableau ? : ");
            int userInput = int.Parse(Console.ReadLine()); // Je récupere la saisie de l'user
            int[] tableau = new int[userInput]; // Je déclare un tableau qui prend en taille la saisie de l'user
            Console.WriteLine("Affectation automatique des valeurs...");

            for (int i = 0; i < tableau.Length; i++) 
            {
                Random random = new Random(); // Je déclare une variable de type random.
                tableau[i] = random.Next(1, 50); // Je dis que tableau contiendra des int aléatoires de 1 a 50,

                if (tableau[i] % 2 == 0)
                {
                    Console.WriteLine($"Le nombre {tableau[i]} est pair");
                } else
                {
                    Console.WriteLine($"Le nombre {tableau[i]} est impair");
                }
            }
            Console.WriteLine("Appuyez sur Enter pour fermer le programme...");


        }
    }
}