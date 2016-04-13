using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing.Test.Unit
{
    public class DoCommentsGetAdded
    {
        public string Comment { get; set; }
        public string Username { get; set; }
        public DateTime CommentedOn { get; set; }

        public bool CommentWasAdded()
        {
            var ticket = new Ticket();
            var manager = new CommentManager(ticket);
            int commentCount = ticket.Comments.Count;
            manager.AddComment(Comment, CommentedOn, Username);
            return ticket.Comments.Count == commentCount + 1;
        }
    }
}
