using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore
{
    public class Dog : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        protected Dog()
        {

        }

        public Dog(Guid id, string name) :
            base(id)
        {
            Name = name;
        }
    }
}