using System;

namespace ConsoleApp1
{
    public abstract class Person
    {
        private readonly int _personId;
        private readonly string _personName;

        public int GetPersonId()
        {
            return _personId;
        }

        public string GetPersonName()
        {
            return _personName;
        }

        protected Person(int id, string name)
        {
            if (id <= 0)
            { throw new ArgumentException("PersonId must be a positive integer."); }
            if (string.IsNullOrEmpty(name))
            { throw new ArgumentException("PersonName cannot be null or empty."); }

            _personId = id;
            _personName = name;
        }

        protected Person()
        {
        }
    }
}