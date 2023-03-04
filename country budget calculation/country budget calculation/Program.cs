namespace country_budget_calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mebleg (AZN): ");
            double amount = double.Parse(Console.ReadLine());
            double usdRate = 1.6997;
            double eurRate = 1.9366;
            double rubRate = 0.0225;

            Console.WriteLine("ABS dollari (USD): " + (amount / usdRate));
            Console.WriteLine("Avro (EUR): " + (amount / eurRate));
            Console.WriteLine("Rusiya rublu (RUB): " + (amount / rubRate));
        }
    }

}