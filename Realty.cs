// <copyright file="Realty.cs" company="Realty">
// Copyright (c) Realty. All rights reserved.
// </copyright>
namespace Domain
{
    using System;
    using Staff;

    /// <summary>
    /// класс.
    /// </summary>
    public class Realty
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Realty"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="realtyType">tpe.</param>
        /// <param name="square">sq.</param>
        /// <param name="address">add.</param>
        /// <param name="price">price.</param>
        public Realty(Guid id, RealtyType realtyType, double square, string address, decimal price)
        {
            this.Id = id;

            if (realtyType is null)
            {
                throw new ArgumentNullException(nameof(realtyType), "RealtyType не может быть null.");
            }

            if (square <= 0)
            {
                throw new ArgumentException("Square должен быть положительным значением.");
            }

            if (price < 0)
            {
                throw new ArgumentException("Price не может быть отрицательным значением.");
            }

            this.RealtyType = realtyType;
            this.Square = square;
            this.Address = address.TrimOrNull() ?? throw new ArgumentNullException(nameof(address));
            this.Price = price;
        }

        [Obsolete("For ORM only")]
        private Realty()
        {
            this.RealtyType = new RealtyType(Guid.Empty, string.Empty);
            this.Address = string.Empty;
        }

        /// <summary>
        /// id.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// realtytype.
        /// </summary>
        public RealtyType RealtyType { get; }

        /// <summary>
        /// square.
        /// </summary>
        public double Square { get; }

        /// <summary>
        /// address.
        /// </summary>
        public string Address { get; }

        /// <summary>
        /// price.
        /// </summary>
        public decimal Price { get; set; }
    }
}