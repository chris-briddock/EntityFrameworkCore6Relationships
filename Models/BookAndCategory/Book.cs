using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace MyTemplate.Models.BookAndCategory;

    // many to many relationship between Book and Category
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BookId { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public List<Category> Categories { get; set; } = null!;
    }

