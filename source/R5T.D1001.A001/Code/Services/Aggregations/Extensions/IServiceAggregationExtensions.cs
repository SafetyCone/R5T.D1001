using System;

using R5T.D1001.A001;


namespace System
{
    public static class IServiceAggregationExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceAggregation other)
            where T : IServiceAggregation
        {
        
        }
    }
}