using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class CommentManager
    {
        private readonly Ticket _ticket;

        public CommentManager(Ticket ticket)
        {
            _ticket = ticket;
        }

        public void AddComment(string comment, DateTime commentedOn, string username)
        {
            _ticket.AddComment(new Comment(comment, username, commentedOn));
        }
    }
}
