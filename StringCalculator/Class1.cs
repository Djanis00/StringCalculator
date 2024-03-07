namespace StringCalculator
{


    public class Calculator
    {
        public static int Add(string numbers)
        {
            // séparées par la virgule
            string[] parts = numbers.Split(',');

            // Vérifier s'il y a exactement deux parties
            if (parts.Length != 2)
            {
                throw new ArgumentException("La chaîne doit être de forme 'x,y'");
            }

            // Convertir les parties en entiers
            int x = int.Parse(parts[0]);
            int y = int.Parse(parts[1]);

            // la somme de x et y
            return x + y;
        }

        public static void Main(string[] args)
        {
            // Exemple d'utilisation
            string input = "7,7";
            int sum = Add(input);
            Console.WriteLine("La somme est : " + sum); 
        }
    }
}

