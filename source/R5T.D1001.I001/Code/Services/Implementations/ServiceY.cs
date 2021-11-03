using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D1001
{
    [ServiceImplementationMarker]
    public class ServiceY : IServiceY, IServiceImplementation
    {
        private IServiceX ServiceX { get; }


        public ServiceY(
            IServiceX serviceX)
        {
            this.ServiceX = serviceX;
        }

        public async Task RunY()
        {
            await this.ServiceX.RunX();

            Console.WriteLine("Ran Y.");

            Console.WriteLine();
        }
    }
}