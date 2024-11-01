// <copyright file="Person.cs" company="Realty">
// Copyright (c) Realty. All rights reserved.
// </copyright>
namespace Domain
{
    using System;

    /// <summary>
    /// класс.
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        public Person(Guid id, string name)
        {
            this.Id = id;
            this.PersonName = name;
        }

        /// <summary>
        /// id.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// name.
        /// </summary>
        public string PersonName { get; }
    }
}