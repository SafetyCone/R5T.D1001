using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D1001.I001
{
    public static class IServiceActionAggregations
    {
        /// <summary>
        /// Adds the <see cref="ServiceZ"/> implementation of <see cref="IServiceX"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IServiceZ> AddServiceZAction(this IServiceAction _,
            IServiceAction<IServiceX> serviceXAction,
            IServiceAction<IServiceY> serviceYAction)
        {
            var serviceAction = _.New<IServiceZ>(services => services.AddServiceZ(
                serviceXAction,
                serviceYAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ServiceY"/> implementation of <see cref="IServiceY"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IServiceY> AddServiceYAction(this IServiceAction _,
            IServiceAction<IServiceX> serviceXAction)
        {
            var serviceAction = _.New<IServiceY>(services => services.AddServiceY(
                serviceXAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ServiceX"/> implementation of <see cref="IServiceX"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IServiceX> AddServiceXAction(this IServiceAction _)
        {
            var serviceAction = _.New<IServiceX>(services => services.AddServiceX());
            return serviceAction;
        }
    }
}
