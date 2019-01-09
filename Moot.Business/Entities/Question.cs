using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Moot.Business.Entities
{
    public class Question :IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Tag Tag { get; set; }
        public string Body { get; set; }
        public User User { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
