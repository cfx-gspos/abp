using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore
{
    public class #Model#Dto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
    }
}