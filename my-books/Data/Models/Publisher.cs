using my_books.Data.Models;

namespace my_books.Data
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation
        public List<Book> Books { get; set; }

    }
}
