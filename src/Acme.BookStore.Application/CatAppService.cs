using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    public class CatAppService :
        CrudAppService<Cat, CatDto, Guid, PagedAndSortedResultRequestDto,
                       CreateUpdateCatDto, CreateUpdateCatDto>,
        ICatAppService
    {
        public CatAppService(IRepository<Cat, Guid> repository)
            : base(repository)
        {

        }
    }
}