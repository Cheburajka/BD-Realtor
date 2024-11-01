// <copyright file="RealtyType.cs" company="Realty">
// Copyright (c) Realty. All rights reserved.
// </copyright>

namespace Domain
{
    using System;
    using Staff;

    /// <summary>
    /// класс.
    /// </summary>
    public class RealtyType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealtyType"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        public RealtyType(Guid id, string name)
        {
            this.Id = id;
            if (string.IsNullOrWhiteSpace(name))
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }
                else
                {
                    throw new ArgumentException("TypeName не может быть пустым или состоять только из пробелов.", nameof(name));
                }
            }

            this.TypeName = name;
        }

        [Obsolete("For ORM only")]
        private RealtyType()
        {
            this.TypeName = string.Empty;
        }

        /// <summary>
        /// id.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// name.
        /// </summary>
        public string TypeName { get; }
    }
}