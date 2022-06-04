using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace MyTemplate.Models.BookAndCategory;

// many to many relationship between Book and Category
public partial class Category
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; } = null!;
    public List<Book> Books { get; set; } = new List<Book>();
}

