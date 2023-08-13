using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    [Table("Author")]

    public class Author
    {
        public Author()
        {
            this.Books = new List<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }


        [InverseProperty("Authors")]
        public ICollection<Book> Books { get; set; }
    }
}
