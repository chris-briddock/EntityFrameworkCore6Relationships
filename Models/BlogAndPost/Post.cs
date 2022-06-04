using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace MyTemplate.Models.BlogAndPost;

//one-to-many relationship between Blog and Post
public partial class Post
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid postId { get; set; } = Guid.NewGuid();
    public string postTitle { get; set; } = null!;
    public string postContent { get; set; } = null!;
    //public Blog Blog { get; set; } = new Blog();
}

