using System;

namespace Ticketing
{
    public class Comment
    {
        public string Text { get; set; }
        public string Username { get; set; }
        public DateTime CommentedOn { get; set; }

        public Comment(string text, string username, DateTime commentedOn)
        {
            Text = text;
            Username = username;
            CommentedOn = commentedOn;
        }
    }
}