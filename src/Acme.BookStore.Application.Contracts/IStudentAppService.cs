using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore
{
    public interface IStudentAppService :
        ICrudAppService< //Defines CRUD methods
            StudentDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
            CreateUpdateStudentDto, //Used to create a new book
            CreateUpdateStudentDto> //Used to update a book
    {

    }
}