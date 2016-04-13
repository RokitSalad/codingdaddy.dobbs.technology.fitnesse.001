using System;
using System.IO;
using System.Net;
using RestSharp;

namespace Ticketing.Test.Component
{
    public class DoCommentsGetAdded
    {
        private HttpStatusCode _result;

        public string Comment { get; set; }
        public string Username { get; set; }
        public DateTime CommentedOn { get; set; }

        public void Setup(string imposterFile)
        {
            var client = new RestClient("http://localhost:2525");
            var request = new RestRequest("imposters", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            using (FileStream imposterJsFs = File.OpenRead(imposterFile))
            {
                using (TextReader reader = new StreamReader(imposterJsFs))
                {
                    string imposterJs = reader.ReadToEnd();
                    request.AddParameter("application/json", imposterJs, ParameterType.RequestBody);
                }
            }
            client.Execute(request);
        }

        public void AddComment()
        {
            var client = new RestClient("http://localhost:9000");
            var request = new RestRequest("api/ticket", Method.POST);
            request.AddJsonBody(new { Number = "TicketABC" });
            request.AddHeader("Content-Type", "application/json");
            IRestResponse restResponse = client.Execute(request);
            _result = restResponse.StatusCode;
        }

        public bool CommentWasAdded()
        {
            return _result != HttpStatusCode.InternalServerError;
        }

        public void TearDown(string port)
        {
            var client = new RestClient("http://localhost:2525");
            var request = new RestRequest($"imposters/{port}", Method.DELETE);
            request.AddHeader("Content-Type", "application/json");
            client.Execute(request);
        }
    }
}
