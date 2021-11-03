using System;

using R5T.T0063;


namespace R5T.D1001.A001
{
    [ServiceActionAggregationIncrementMarker]
    public interface IServiceZActionAggregationIncrement : T0063.IServiceActionAggregationIncrement
    {
        IServiceAction<IServiceX> ServiceXAction { get; set; }
        IServiceAction<IServiceY> ServiceYAction { get; set; }
        IServiceAction<IServiceZ> ServiceZAction { get; set; }
    }
}