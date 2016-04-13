using System.CodeDom;
using System.Collections.Generic;

namespace Ticketing
{
    public class Ticket
    {
        public string Number { get; set; }

        public List<Comment> Comments { get; set; }

        public Ticket()
        {
            Comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
    }
}