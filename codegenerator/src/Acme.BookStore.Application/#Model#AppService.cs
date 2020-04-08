using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    public class #Model#AppService :
        CrudAppService<#Model#, #Model#Dto, Guid, PagedAndSortedResultRequestDto,
                       CreateUpdate#Model#Dto, CreateUpdate#Model#Dto>,
        I#Model#AppService
    {
        public #Model#AppService(IRepository<#Model#, Guid> repository)
            : base(repository)
        {

        }
    }
}