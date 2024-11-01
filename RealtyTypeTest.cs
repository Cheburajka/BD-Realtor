// <copyright file="Program.cs" company="Realty">
// Copyright (c) Realty. All rights reserved.
// </copyright>

namespace DomainTests
{
    using NUnit.Framework;
    using System;
    using Domain;

    [TestFixture]
    public class RealtyTypeTests
    {
        [Test]
        public void Constructor_ValidParameters_CreatesInstance()
        {
            // Arrange
            var id = Guid.NewGuid();
            var name = "Apartment";

            // Act
            var realtyType = new RealtyType(id, name);

            // Assert
            Assert.AreEqual(id, realtyType.Id);
            Assert.AreEqual(name, realtyType.TypeName);
        }

        [Test]
        public void Constructor_NullName_ThrowsArgumentNullException()
        {
            // Arrange
            var id = Guid.NewGuid();
            string name = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new RealtyType(id, name));
        }

        [Test]
        public void Constructor_EmptyName_ThrowsArgumentException()
        {
            // Arrange
            var id = Guid.NewGuid();
            var name = string.Empty;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new RealtyType(id, name));
        }
    }
}