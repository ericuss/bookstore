﻿namespace Bookstore.Entities.Core
{
    using Bookstore.Infrastructure.Entity;
    using System;

    /// <summary>
    /// Core of entities of EF
    /// </summary>
    public class EntityCore : IEntityCore
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public Guid Id { get; set; }
    }
}
