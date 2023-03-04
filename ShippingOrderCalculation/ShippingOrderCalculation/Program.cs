namespace ShippingOrderCalculation
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firma: Adidas");
            Console.Write("Ayaqqabi sayi: ");
            int adidasCount = int.Parse(Console.ReadLine());
            Console.Write("Birinin qiymeti ($): ");
            double adidasPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Firma: Gucci");
            Console.Write("Ayaqqabi sayi: ");
            int gucciCount = int.Parse(Console.ReadLine());
            Console.Write("Birinin qiymeti ($): ");
            double gucciPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Firma: Nike");
            Console.Write("Ayaqqabi sayi: ");
            int nikeCount = int.Parse(Console.ReadLine());
            Console.Write("Birinin qiymeti ($): ");
            double nikePrice = double.Parse(Console.ReadLine());

            double totalCost = (adidasCount * adidasPrice) + (gucciCount * gucciPrice) + (nikeCount * nikePrice);
            Console.WriteLine("Hamisinin birlikde qiymeti ($): " + totalCost);
        }
    }

}