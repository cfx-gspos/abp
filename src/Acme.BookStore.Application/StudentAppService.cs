using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    public class StudentAppService :
        CrudAppService<Student, StudentDto, Guid, PagedAndSortedResultRequestDto,
                       CreateUpdateStudentDto, CreateUpdateStudentDto>,
        IStudentAppService
    {
        public StudentAppService(IRepository<Student, Guid> repository)
            : base(repository)
        {

        }
    }
}