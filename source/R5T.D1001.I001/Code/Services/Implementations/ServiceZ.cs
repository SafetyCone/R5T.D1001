using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D1001
{
    [ServiceImplementationMarker]
    public class ServiceZ : IServiceZ, IServiceImplementation
    {
        private IServiceX ServiceX { get; }
        private IServiceY ServiceY { get; }


        public ServiceZ(
            IServiceX serviceX,
            IServiceY serviceY)
        {
            this.ServiceX = serviceX;
            this.ServiceY = serviceY;
        }

        public async Task RunZ()
        {
            await this.ServiceX.RunX();
            await this.ServiceY.RunY();

            Console.WriteLine("Ran Z.");

            Console.WriteLine();
        }
    }
}