using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.ViewModels
{
    [Table("BookByAuthor")]

    public class BookByAuthor
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "*")]
        public int AuthorId { get; set; }

        [Required (ErrorMessage = "*")]
        public int BookId { get; set; }
    }
}
