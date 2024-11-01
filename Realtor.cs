// <copyright file="Realtor.cs" company="Realty">
// Copyright (c) Realty. All rights reserved.
// </copyright>
namespace Domain
{
    using System;

    /// <summary>
    /// класс.
    /// </summary>
    public class Realtor : Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Realtor"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">namt.</param>
        public Realtor(
            Guid id,
            string name)
            : base(id, name)
        {
        }
    }
}