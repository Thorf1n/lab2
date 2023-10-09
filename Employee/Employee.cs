
namespace Employee
{
    internal class Employee
    {
        private string _lastName;
        private string _firstName;
        private string _position;
        private int _experience;
        private double _salary;

        public Employee(string lastName, string firstName, string position, int experience, double baseSalary)
        {
            _lastName = lastName;
            _firstName = firstName;
            _position = position;
            _experience = experience;
            _salary = CalculateSalary(baseSalary);
        }

        private double CalculateSalary(double baseSalary)
        {
            
            return baseSalary + _experience * 1000;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Last Name: {_lastName}");
            Console.WriteLine($"First Name: {_firstName}");
            Console.WriteLine($"Position: {_position}");
            Console.WriteLine($"Experience: {_experience} years");
            Console.WriteLine($"Salary: ${_salary:F2}");
        }
    }
}

