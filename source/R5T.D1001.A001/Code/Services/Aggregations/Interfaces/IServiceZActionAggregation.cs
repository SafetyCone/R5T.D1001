using System;

using R5T.T0063;


namespace R5T.D1001.A001
{
    [ServiceActionAggregationMarker]
    public interface IServiceZActionAggregation : T0063.IServiceActionAggregation,
        IServiceZActionAggregationIncrement
    {
    }
}