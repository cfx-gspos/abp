using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore
{
    public class CatDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
    }
}