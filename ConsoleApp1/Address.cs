

class Address
{
    public int index { get; set; }
    public string country { get; set; }
    public string city { get; set; }
    public string street { get; set; }
    public int house { get; set; }
    public int apartment { get; set; }

    public Address(int index, string country, string city, string street, int house, int apartment)
    {
        this.index = 02234;
        this.country = "Ukraine";
        this.city = "Kyiv";
        this.street = "Lisowa";
        this.house = 9;
        this.apartment = 45;
    }

    public static void Print(Address address)
    {
        Console.WriteLine(
            $"Index = {address.index}, Country = {address.country}, City = {address.city}," +
            $"Street = {address.street}, House = {address.house}, Apartment = {address.apartment}."
        );
    }
}