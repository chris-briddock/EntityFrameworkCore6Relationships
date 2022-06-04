using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace MyTemplate.Models.BlogAndPost;

//one-to-many relationship between Blog and Post
public partial class Blog
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid blogId { get; set; } = Guid.NewGuid();
    public string blogName { get; set; } = null!;
    public string blogDisplayName { get; set; } = null!;
    public string url
    {
        get
        {
            return blogName + ".myblogspot.com";
        }
        set
        {

        }
    }
    public string? emailAddress { get; set; } = null!;
    public List<Post> Posts { get; set; } = null!;
}

