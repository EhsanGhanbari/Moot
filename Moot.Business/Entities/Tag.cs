using System;

namespace Moot.Business.Entities
{
    public class Tag:IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }

    }
}