using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;

    [TestClass]
    public class RealtyTypeTests
    {
        [TestMethod]
        public void ConstructorValidParametersCreatesInstance()
        {
            int id = 1;
            string name = "Аппартаменты";

            RealtyTypeTests realtyType = new RealtyType(id, name);

            Assert.AreEqual(id, realtyType.IdTypeRealty);
            Assert.AreEqual(name, realtyType.TypeName);
        }

        [TestMethod]
        public void IdTypeRealtySetNegativeValue()
        {
            int invalidId = -1;
            string name = "Аппартаменты";

            Assert.Throws<ArgumentException>(() => new RealtyType(invalidId, name));
        }

        [TestMethod]
        public void TypeNameSetNull()
        {
            int id = 1;
            string invalidName = "";

            Assert.Throws<ArgumentException>(() => new RealtyType(id, invalidName));
        }
    }

    [TestClass]
    public class RealtyTests
    {
        private RealtyType _validRealtyType;

        [SetUp]
        public void Setup()
        {
            _validRealtyType = new RealtyType(1, "Аппартаменты");
        }

        [Test]
        public void ConstructorValidParametersCreatesInstance()
        {
            int id = 1;
            double square = 100.0;
            string address = "г. Москва, улица, дом";
            decimal price = 200000.0m;

            Realty realty = new Realty(id, _validRealtyType, square, address, price);

            Assert.AreEqual(id, realty.IDRealty);
            Assert.AreEqual(_validRealtyType, realty.RealtyType);
            Assert.AreEqual(square, realty.Square);
            Assert.AreEqual(address, realty.Address);
            Assert.AreEqual(price, realty.Price);
        }

        [Test]
        public void IDRealtySetNegativeValue()
        {
            int invalidId = -1;
            double square = 100.0;
            string address = "г. Москва, улица, дом";
            decimal price = 200000.0m;

            Assert.Throws<ArgumentException>(() => new Realty(invalidId, _validRealtyType, square, address, price));
        }

        [Test]
        public void RealtyTypeSetNull()
        {
            int id = 1;
            double square = 100.0;
            string address = "г. Москва, улица, дом";
            decimal price = 200000.0m;

            Assert.Throws<ArgumentNullException>(() => new Realty(id, null, square, address, price));
        }

        [Test]
        public void SquareSetNegativeValue()
        {
            int id = 1;
            double invalidSquare = -1.0;
            string address = "г. Москва, улица, дом";
            decimal price = 200000.0m;

            Assert.Throws<ArgumentException>(() => new Realty(id, _validRealtyType, invalidSquare, address, price));
        }

        [Test]
        public void AddressSetNull()
        {
            int id = 1;
            double square = 100.0;
            string invalidAddress = "";
            decimal price = 200000.0m;

            Assert.Throws<ArgumentException>(() => new Realty(id, _validRealtyType, square, invalidAddress, price));
        }

        [Test]
        public void PriceSetNegativeValue()
        {
            int id = 1;
            double square = 100.0;
            string address = "г. Москва, улица, дом";
            decimal invalidPrice = -1.0m;

            Assert.Throws<ArgumentException>(() => new Realty(id, _validRealtyType, square, address, invalidPrice));
        }
    }