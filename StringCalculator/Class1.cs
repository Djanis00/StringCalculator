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

            // Liste pour stocker les nombres négatifs et leurs positions
            List<string> negatives = new List<string>();

            int sum = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                // Convertir chaque partie en nombre
                int num = int.Parse(parts[i]);

                // Vérifier si le nombre est négatif
                if (num < 0)
                {
                    negatives.Add(num.ToString() + " (Position " + (i + 1) + ")");
                }

                // Ajouter le nombre à la somme
                sum += num;
            }

            // S'il y a des nombres négatifs, lancer une exception avec leur liste et positions
            if (negatives.Count > 0)
            {
                string message = "Nombres négatifs trouvés : " + string.Join(", ", negatives);
                throw new ArgumentException(message);
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            // Exemple d'utilisation avec différents nombres d'arguments
            int sum1 = Add("5, 7");
            Console.WriteLine("La somme est : " + sum1); // Output: La somme est : 12

            int sum2 = Add("7,-8,7");
            Console.WriteLine("La somme est : " + sum2); // Output: Exception

            int sum3 = Add("1, -2, 3, 4, -5");
            Console.WriteLine("La somme est : " + sum3); // Output: Exception
        }

    }
}



