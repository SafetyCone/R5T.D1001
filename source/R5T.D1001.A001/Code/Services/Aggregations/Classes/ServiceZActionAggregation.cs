using System;

using R5T.T0063;


namespace R5T.D1001.A001
{
    [ServiceActionAggregationImplementationMarker]
    public class ServiceZActionAggregation : IServiceZActionAggregation
    {
        public IServiceAction<IServiceX> ServiceXAction { get; set; }
        public IServiceAction<IServiceY> ServiceYAction { get; set; }
        public IServiceAction<IServiceZ> ServiceZAction { get; set; }
    }
}