using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore
{
    public class Student : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }


        protected Student()
        {

        }

        public Student(Guid id,string name) :
            base(id)
        {
            Name = name;

        }
    }
}