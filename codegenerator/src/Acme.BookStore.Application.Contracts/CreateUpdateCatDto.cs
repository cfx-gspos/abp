using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore
{
    public class CreateUpdateCatDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
    }
}