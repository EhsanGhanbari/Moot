using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moot.Business.Entities
{
    public class Blog:IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Post { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public DateTime CreationTime { get; set; }


    }
}
