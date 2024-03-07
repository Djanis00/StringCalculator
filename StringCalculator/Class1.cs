namespace StringCalculator
{

    using System;

    public class Calculator
    {
        public static int Add(string numbers)
        {
            // Supprimer les espaces de la chaîne d'entrée
            numbers = numbers.Replace(" ", "");

            // Diviser la chaîne de caractères en parties séparées par la virgule
            string[] parts = numbers.Split(',');

            int sum = 0;
            foreach (string part in parts)
            {
                // Convertir chaque partie en nombre et l'ajouter à la somme
                sum += int.Parse(part);
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            // Exemple d'utilisation avec différents nombres d'arguments
            int sum1 = Add("5, 7");
            Console.WriteLine("La somme est : " + sum1); // Output: La somme est : 12

            int sum2 = Add("7,8,7");
            Console.WriteLine("La somme est : " + sum2); // Output: La somme est : 22

            int sum3 = Add("1, 2, 3, 4, 5");
            Console.WriteLine("La somme est : " + sum3); // Output: La somme est : 15
        }

    }
}



