using ConsoleApp1;
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Создание объектов RealtyType
            RealtyType apartmentType = new RealtyType(1, "Apartment");
            RealtyType houseType = new RealtyType(2, "House");

            // Создание объектов Realty
            Realty realty1 = new Realty(1, apartmentType, 100.0, "123 Main St", 200000.0m);
            Realty realty2 = new Realty(2, houseType, 200.0, "456 Elm St", 500000.0m);

            // Создание объектов Realtor
            Realtor realtor1 = new Realtor(1, "John Doe");
            Realtor realtor2 = new Realtor(2, "Jane Smith");

            // Создание объектов Client
            Client client1 = new Client(1, "Alice Johnson");
            Client client2 = new Client(2, "Bob Brown");

            // Вывод информации на консоль
            Console.WriteLine("Realty Types:");
            Console.WriteLine($"ID: {apartmentType.GetIdTypeRealty()}, Name: {apartmentType.GetTypeName()}");
            Console.WriteLine($"ID: {houseType.GetIdTypeRealty()}, Name: {houseType.GetTypeName()}");

            Console.WriteLine("\nRealties:");
            Console.WriteLine($"ID: {realty1.GetIDRealty()}, Type: {realty1.GetRealtyType().GetTypeName()}, Square: {realty1.GetSquare()}, Address: {realty1.GetAddress()}, Price: {realty1.GetPrice()}");
            Console.WriteLine($"ID: {realty2.GetIDRealty()}, Type: {realty2.GetRealtyType().GetTypeName()}, Square: {realty2.GetSquare()}, Address: {realty2.GetAddress()}, Price: {realty2.GetPrice()}");

            Console.WriteLine("\nRealtors:");
            Console.WriteLine($"ID: {realtor1.GetPersonId()}, Name: {realtor1.GetPersonName()}");
            Console.WriteLine($"ID: {realtor2.GetPersonId()}, Name: {realtor2.GetPersonName()}");

            Console.WriteLine("\nClients:");
            Console.WriteLine($"ID: {client1.GetPersonId()}, Name: {client1.GetPersonName()}");
            Console.WriteLine($"ID: {client2.GetPersonId()}, Name: {client2.GetPersonName()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}