

namespace User
{
    internal class User
    {
        private string _login;
        private string _firstName;
        private string _lastName;
        private int _age;
        private readonly DateTime _registrationDate;

        public User(string login, string firstName, string lastName, int age)
        {
            _login = login;
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _registrationDate = DateTime.Now;
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine($"Login: {_login}");
            Console.WriteLine($"First Name: {_firstName}");
            Console.WriteLine($"Last Name: {_lastName}");
            Console.WriteLine($"Age: {_age} years");
            Console.WriteLine($"Registration Date: {_registrationDate}");
        }
    }
}
