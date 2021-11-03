using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D1001.D001
{
    [ServiceDefinitionMarker]
    public interface IServiceA : IServiceDefinition
    {
        Task RunA();
    }
}
