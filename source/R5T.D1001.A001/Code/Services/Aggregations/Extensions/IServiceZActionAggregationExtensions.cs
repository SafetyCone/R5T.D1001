using System;

using R5T.D1001.A001;


namespace System
{
    public static class IServiceZActionAggregationExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceZActionAggregation other)
            where T : IServiceZActionAggregation
        {
            (aggregation as IServiceZActionAggregationIncrement).FillFrom(other);

            return aggregation;
        }
    }
}