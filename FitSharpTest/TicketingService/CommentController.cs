using System.Web.Http;
using Ticketing;

namespace TicketingService
{
    public class CommentController : ApiController
    {

        public void Post(Comment comment)
        {
            BackEndService.Ticket.AddComment(comment);
        }

        public int GetCount()
        {
            return BackEndService.Ticket.Comments.Count;
        }
    }
}
