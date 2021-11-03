using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D1001.D001.I001
{
    [ServiceImplementationMarker]
    public class ServiceA : IServiceA, IServiceImplementation
    {
        private IServiceZ ServiceZ { get; }


        public ServiceA(
            IServiceZ serviceZ)
        {
            this.ServiceZ = serviceZ;
        }

        public async Task RunA()
        {
            await this.ServiceZ.RunZ();

            Console.WriteLine("Ran A.");

            Console.WriteLine();
        }
    }
}
