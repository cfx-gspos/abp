using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore
{
    public interface ICatAppService :
        ICrudAppService< //Defines CRUD methods
            CatDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
            CreateUpdateCatDto, //Used to create a new book
            CreateUpdateCatDto> //Used to update a book
    {

    }
}