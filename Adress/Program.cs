

namespace Adress
{
    internal class Program
    {
        static void Main()
        {
            Address address = new Address(1, "Ukraine", "Kyiv", "Lisowa", 5, 6);

            Address.Print(address);
        }


    }
}
