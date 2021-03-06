using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D1001.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ServiceZ"/> implementation of <see cref="IServiceX"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddServiceZ(this IServiceCollection services,
            IServiceAction<IServiceX> serviceXAction,
            IServiceAction<IServiceY> serviceYAction)
        {
            services.AddSingleton<IServiceZ, ServiceZ>()
                .Run(serviceXAction)
                .Run(serviceYAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ServiceY"/> implementation of <see cref="IServiceY"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddServiceY(this IServiceCollection services,
            IServiceAction<IServiceX> serviceXAction)
        {
            services.AddSingleton<IServiceY, ServiceY>()
                .Run(serviceXAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ServiceX"/> implementation of <see cref="IServiceX"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddServiceX(this IServiceCollection services)
        {
            services.AddSingleton<IServiceX, ServiceX>();

            return services;
        }
    }
}