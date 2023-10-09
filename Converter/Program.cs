

namespace Converter
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the amount in UAH:");
            double amountUAH = Convert.ToDouble(Console.ReadLine());

            Converter converter = new Converter(37, 40, 8 );

            Console.WriteLine($"Amount in USD: {converter.UAHtoUSD(amountUAH):F2}");
            Console.WriteLine($"Amount in EUR: {converter.UAHtoEUR(amountUAH):F2}");
            Console.WriteLine($"Amount in PLN: {converter.UAHtoPLN(amountUAH):F2}");

            Console.WriteLine("Enter the amount in USD:");
            double amountUSD = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Amount in UAH: {converter.USDtoUAH(amountUSD):F2}");

            Console.WriteLine("Enter the amount in EUR:");
            double amountEUR = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Amount in UAH: {converter.EURtoUAH(amountEUR):F2}");

            Console.WriteLine("Enter the amount in PLN:");
            double amountPLN = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Amount in UAH: {converter.PLNtoUAH(amountPLN):F2}");


        }
    }




}
