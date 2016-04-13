using System;
using RestSharp;

namespace Ticketing.Test.Integration
{
    public class DoCommentsGetAdded
    {
        public string Comment { get; set; }
        public string Username { get; set; }
        public DateTime CommentedOn { get; set; }

        public bool CommentWasAdded()
        {
            var client = new RestClient("http://localhost:9000");
            var request = new RestRequest("api/comment", Method.POST);
            request.AddJsonBody(new {Text = Comment, Username = Username, CommentedOn = CommentedOn});
            request.AddHeader("Content-Type", "application/json");
            client.Execute(request);
            
            var checkRequest = new RestRequest("api/comment/count", Method.GET);
            IRestResponse checkResponse = client.Execute(checkRequest);

            return checkResponse.Content == "1";
        }
    }
}
