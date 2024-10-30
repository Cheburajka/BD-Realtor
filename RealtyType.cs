using System;

namespace ConsoleApp1
{
    public class RealtyType
    {
        private readonly int idTypeRealty;
        private readonly string typeName;

        public int GetIdTypeRealty()
        {
            return idTypeRealty;
        }

        public string GetTypeName()
        {
            return typeName;
        }

        public RealtyType(int id, string name)
        {
            if (id <= 0)
            { throw new ArgumentException("IdTypeRealty должен быть положительным значением."); }
            if (string.IsNullOrWhiteSpace(name))
            { throw new ArgumentException("TypeName не может быть пустым или состоять только из пробелов."); }

            idTypeRealty = id;
            typeName = name;
        }

        public RealtyType() { }
    }
}