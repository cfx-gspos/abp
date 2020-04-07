using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore
{
    public class Cat : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
 

        protected Cat()
        {

        }

        public Cat(Guid id, string name ) :
            base(id)
        {
            Name = name;
   
        }
    }
}