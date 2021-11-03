using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D1001.D001.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ServiceA"/> implementation of <see cref="IServiceA"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IServiceA> AddServiceAAction(this IServiceAction _,
            IServiceAction<IServiceZ> serviceZAction)
        {
            var serviceAction = _.New<IServiceA>(services => services.AddServiceA(
                serviceZAction));

            return serviceAction;
        }
    }
}
