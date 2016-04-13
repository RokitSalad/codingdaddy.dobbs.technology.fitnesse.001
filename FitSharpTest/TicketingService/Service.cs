using System;
using Microsoft.Owin.Hosting;

namespace TicketingService
{
    public class Service
    {
        private IDisposable _webApp;

        public void Start()
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            _webApp = WebApp.Start<Startup>(url: baseAddress);
        }

        public void Stop()
        {
            _webApp.Dispose();
        }
    }
}
