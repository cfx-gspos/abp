using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore
{
    public class #Model# : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
 

        protected #Model#()
        {

        }

        public #Model#(Guid id, string name ) :
            base(id)
        {
            Name = name;
   
        }
    }
}