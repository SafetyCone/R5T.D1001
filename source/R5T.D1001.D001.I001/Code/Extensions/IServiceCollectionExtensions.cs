using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D1001.D001.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ServiceA"/> implementation of <see cref="IServiceA"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddServiceA(this IServiceCollection services,
            IServiceAction<IServiceZ> serviceZAction)
        {
            services.AddSingleton<IServiceA, ServiceA>()
                .Run(serviceZAction)
                ;

            return services;
        }
    }
}
