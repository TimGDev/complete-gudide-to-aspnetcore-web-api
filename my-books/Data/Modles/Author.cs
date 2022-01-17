using System.Collections.Generic;

namespace my_books.Data.Modles
{
    public class Author
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        //Navigaion Properties
        public List<Book_Author> Book_Author { get; set; }

    }
}
