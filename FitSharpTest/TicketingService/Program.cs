using System;
using Topshelf;

namespace TicketingService
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(
                c =>
                {

                    c.Service<Service>(s =>
                    {
                        s.ConstructUsing(name => new Service()); 
                        
                        s.WhenStarted(service => service.Start());
                        s.WhenStopped(service => service.Stop());
                    });
                    
                    c.SetServiceName("TicketingService");
                    c.SetDisplayName("Ticketing Service");
                    c.SetDescription("Ticketing Service");

                    c.EnablePauseAndContinue();
                    c.EnableShutdown();

                    c.RunAsLocalSystem();
                    c.StartAutomatically();
                });

            Console.ReadKey();
        }
    }
}
