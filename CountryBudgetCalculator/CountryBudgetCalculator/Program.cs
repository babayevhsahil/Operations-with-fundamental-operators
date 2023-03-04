namespace CountryBudgetCalculator
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Büdce: ");
            double budget = double.Parse(Console.ReadLine());
            double defenseSpending = budget * 0.20;
            double techSpending = budget * 0.10;
            double remainingBudget = budget - defenseSpending - techSpending;

            Console.WriteLine("Mudafie Nazirliyine: " + defenseSpending);
            Console.WriteLine("Yüksek Texnologiyalar Nazirliyine: " + techSpending);
            Console.WriteLine("Yerde qalan budce: " + remainingBudget);
        }
    }

}