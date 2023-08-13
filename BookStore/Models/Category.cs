using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    [Table("Category")]
    public class Category
    {
        public Category()
        {
            this.Books = new List<Book>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
