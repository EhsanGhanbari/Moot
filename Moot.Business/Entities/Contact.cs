using System;

namespace Moot.Business.Entities
{
    public class Contact:IAggregateRoot
    {
        public Guid Id { get; set;}
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime ContactDate { get; set; }
        public string ReplyBody { get; set; }
    }
}
