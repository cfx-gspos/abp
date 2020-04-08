using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore
{
    public interface I#Model#AppService :
        ICrudAppService< //Defines CRUD methods
            #Model#Dto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
            CreateUpdate#Model#Dto, //Used to create a new book
            CreateUpdate#Model#Dto> //Used to update a book
    {

    }
}