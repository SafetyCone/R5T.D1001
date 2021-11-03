using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D1001.I001
{
    [ServiceImplementationMarker]
    public class ServiceX : IServiceX, IServiceImplementation
    {
        public Task RunX()
        {
            Console.WriteLine("Ran X.");

            return Task.CompletedTask;
        }
    }
}