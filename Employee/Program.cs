namespace Employee
{
    internal class Programm
    {
        static void Main()
        {
            Employee employee1 = new Employee("Davis", "Oliver", "Beginner", 1, 1500);
            Employee employee2 = new Employee("Miller", "Hanna", "Developer", 4, 4500);
            Employee employee3 = new Employee("Wilson", "George", "Manager", 7, 17000);

            Console.WriteLine("Information about the first employee:");
            employee1.DisplayInfo();

            Console.WriteLine("\nInformation about the second employee:");
            employee2.DisplayInfo();

            Console.WriteLine("\nInformation about the third employee:");
            employee3.DisplayInfo();
        }


    }
        
        
        
        




}