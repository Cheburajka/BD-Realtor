// <copyright file="Client.cs" company="Realty">
// Copyright (c) Realty. All rights reserved.
// </copyright>
namespace Domain
{
    using System;

    /// <summary>
    /// класс.
    /// </summary>
    public class Client : Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">namt.</param>
        public Client(
            Guid id,
            string name)
            : base(id, name)
        {
        }
    }
}