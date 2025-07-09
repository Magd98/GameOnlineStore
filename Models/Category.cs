using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameOnlineStore.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(30)]
    [DisplayName("Category Name")]
    public string? Name { get; set; }
    [DisplayName("Display Order")]
    [Range(1, 500, ErrorMessage = "The number must be within 1-100")]
    public int DisplayOrder { get; set; }
}
