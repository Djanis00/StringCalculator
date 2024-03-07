namespace StringCalculator
{

    using System;

    public class Calculator
    {
        public static int Add(string numbers)
        {
            string[] parts = numbers.Split(',');

            
            if (parts.Length != 2)
            {
                throw new ArgumentException("La chaîne doit être de forme 'x,y,'");
            }

            
            int x = int.Parse(parts[0]);
            int y = int.Parse(parts[1]);

            
            return x + y;
        }

        public static void Main(string[] args)
        {
            // Exemple d'utilisation avec différents nombres d'arguments
            int sum1 = Add("5, 7");
            Console.WriteLine("La somme est : " + sum1); // Output: La somme est : 12

            int sum2 = Add("9,7");
            Console.WriteLine("La somme est : " + sum2); // Output: La somme est : 22

            
        }
    }

}

