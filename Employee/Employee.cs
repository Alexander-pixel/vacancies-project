using System;

namespace ModelEmployee
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private string _position;

        public string FirstName 
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public DateTime BirthDate
        {
            get => _birthDate;
            set => _birthDate = value;
        }

        public string Position 
        {
            get => _position;
            set => _position = value;
        }

        public Employee()
        {

        }

        public Employee(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }
    }
}
