using AutoMapper;

namespace Acme.BookStore
{
    public class BookStoreApplicationAutoMapperProfile : Profile
    {
        public BookStoreApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>(); //<--added this line-->

            CreateMap<Student, StudentDto>();
            CreateMap<CreateUpdateStudentDto, Student>(); //<--added this line-->

            CreateMap<Cat, CatDto>();
            CreateMap<CreateUpdateCatDto, Cat>(); //<--added this line-->
        }
    }
}
