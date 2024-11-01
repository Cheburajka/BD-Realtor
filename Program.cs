// <copyright file="Program.cs" company="Realty">
// Copyright (c) Realty. All rights reserved.
// </copyright>
// <copyright file="Program.cs" company="Realty">
// Copyright (c) Realty. All rights reserved.
// </copyright>
namespace Demo
{
    using System;
    using Domain;

    /// <summary>
    /// программа.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// вход в программу.
        /// </summary>
        public static void Main()
        {
            try
            {
                // Создание объектов RealtyType
                var apartmentType = new RealtyType(Guid.NewGuid(), "Apartment");
                var houseType = new RealtyType(Guid.NewGuid(), "House");

                // Создание объектов Realty
                var realty1 = new Realty(Guid.NewGuid(), apartmentType, 100.0, "123 Main St", 200000.0m);
                var realty2 = new Realty(Guid.NewGuid(), houseType, 200.0, "456 Elm St", 500000.0m);

                // Создание объектов Realtor
                var realtor1 = new Realtor(Guid.NewGuid(), "John Doe");
                var realtor2 = new Realtor(Guid.NewGuid(), "Jane Smith");

                // Создание объектов Client
                var client1 = new Client(Guid.NewGuid(), "Alice Johnson");
                var client2 = new Client(Guid.NewGuid(), "Bob Brown");

                // Вывод информации на консоль
                Console.WriteLine("Realty Types:");
                Console.WriteLine($"ID: {apartmentType.Id}, Name: {apartmentType.TypeName}");
                Console.WriteLine($"ID: {houseType.Id}, Name: {houseType.TypeName}");

                Console.WriteLine("\nRealties:");
                Console.WriteLine($"ID: {realty1.Id}, Type: {realty1.RealtyType.TypeName}, Square: {realty1.Square}, Address: {realty1.Address}, Price: {realty1.Price}");
                Console.WriteLine($"ID: {realty2.Id}, Type: {realty2.RealtyType.TypeName}, Square: {realty2.Square}, Address: {realty2.Address}, Price: {realty2.Price}");

                Console.WriteLine("\nRealtors:");
                Console.WriteLine($"ID: {realtor1.Id}, Name: {realtor1.PersonName}");
                Console.WriteLine($"ID: {realtor2.Id}, Name: {realtor2.PersonName}");

                Console.WriteLine("\nClients:");
                Console.WriteLine($"ID: {client1.Id}, Name: {client1.PersonName}");
                Console.WriteLine($"ID: {client2.Id}, Name: {client2.PersonName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}