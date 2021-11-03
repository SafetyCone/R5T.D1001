using System;

using R5T.T0062;

using R5T.D1001.I001;


namespace R5T.D1001.A001
{
    public static class IServiceActionExtensions
    {
        public static IServiceZActionAggregation AddServiceZActionAggregation(this IServiceAction _)
        {
            var serviceXAction = _.AddServiceXAction();

            var serviceYAction = _.AddServiceYAction(
                serviceXAction);

            var serviceZAction = _.AddServiceZAction(
                serviceXAction,
                serviceYAction);

            var output = new ServiceZActionAggregation
            {
                ServiceXAction = serviceXAction,
                ServiceYAction = serviceYAction,
                ServiceZAction = serviceZAction,
            };

            return output;
        }
    }
}