using System.IO;
using System.Net;
using System.Web;
using System.Web.Http;
using RestSharp;
using Ticketing;

namespace TicketingService
{
    public class TicketController : ApiController
    {
        public void Post(Ticket ticket)
        {
            var client = new RestClient("http://localhost:9999");
            var request = new RestRequest("ticketservice", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(ticket);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.Created)
            {
                throw new HttpException(500, "Failed to create ticket");
            }
        }
    }
}
