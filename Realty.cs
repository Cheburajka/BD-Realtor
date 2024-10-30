using System;
//using static RealtyType;

namespace ConsoleApp1
{
    public class Realty
    {
        private readonly int idRealty;
        private readonly RealtyType realtyType;
        private readonly double square;
        private readonly string address;
        private readonly decimal price;

        public int GetIDRealty()
        {
            return idRealty;
        }

        public RealtyType GetRealtyType()
        {
            return realtyType;
        }

        public double GetSquare()
        {
            return square;
        }

        public string GetAddress()
        {
            return address;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public Realty(int id, RealtyType realtyType, double square, string address, decimal price)
        {
            if (id <= 0)
            { throw new ArgumentException("IDRealty должен быть положительным значением."); }
            if (realtyType == null)
            { throw new ArgumentNullException(nameof(realtyType), "RealtyType не может быть null."); }
            if (square <= 0)
            { throw new ArgumentException("Square должен быть положительным значением."); }
            if (string.IsNullOrWhiteSpace(address))
            { throw new ArgumentException("Address не может быть пустым или состоять только из пробелов."); }
            if (price < 0)
            { throw new ArgumentException("Price не может быть отрицательным значением."); }

            idRealty = id;
            this.realtyType = realtyType;
            this.square = square;
            this.address = address;
            this.price = price;

        }
        public Realty()
        {
        }
    }
}