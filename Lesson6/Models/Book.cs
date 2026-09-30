using System.ComponentModel.DataAnnotations;

namespace Lesson6.Models;

public class Book
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Tên sách không được để trống")]
    [Display(Name = "Tên sách")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Tác giả không được để trống")]
    [Display(Name = "Tác giả")]
    public string Author { get; set; } = string.Empty;

    [Display(Name = "Giá sách")]
    [Range(typeof(decimal), "0.01", "79228162514264337593543950335", ErrorMessage = "Giá phải lớn hơn 0")]
    public decimal Price { get; set; }
}
