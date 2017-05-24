﻿namespace Bookstore.Entities
{
    using Bookstore.Entities.Core;
    using System.Collections.Generic;

    /// <summary>
    /// Publisher entity
    /// </summary>
    public class Publisher : EntityCore
    {
        /// <summary>
        /// Name of publisher
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Books
        /// </summary>
        public List<Book> Books { get; set; }
    }
}
