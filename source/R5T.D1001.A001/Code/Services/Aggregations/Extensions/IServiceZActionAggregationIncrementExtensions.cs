using System;

using R5T.D1001.A001;


namespace System
{
    public static class IServiceZActionAggregationIncrementExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceZActionAggregationIncrement other)
            where T : IServiceZActionAggregationIncrement
        {
            aggregation.ServiceXAction = other.ServiceXAction;
            aggregation.ServiceYAction = other.ServiceYAction;
            aggregation.ServiceZAction = other.ServiceZAction;

            return aggregation;
        }
    }
}