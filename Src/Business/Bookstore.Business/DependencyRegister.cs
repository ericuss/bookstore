﻿namespace Bookstore.Business
{
    using Bookstore.Business.Core;
    using Bookstore.Entities;
    using Bookstore.Infrastructure.Business;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Register dependencies
    /// </summary> 
    public static class DependencyRegister
    {
        /// <summary>
        /// Register function
        /// </summary>
        /// <param name="services">service collection</param>
        public static void Register(IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddSingleton<IBusinessCore<Author>, BusinessCore<Author>>();
            services.AddSingleton<IBusinessCore<Book>, BusinessCore<Book>>();
            services.AddSingleton<IBusinessCore<Publisher>, BusinessCore<Publisher>>();
            services.AddSingleton<IBusinessCore<Serie>, BusinessCore<Serie>>();

            DataAccess.DependencyRegister.Register(services, configuration);
        }
    }
}
