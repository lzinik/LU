using ej_backend.Model;
using System.Collections.Generic;
using System.Linq;


namespace ej_backend.Services
{
    public class BookService : IBookService
    {
        private List<Book> list;

        public BookService()
        {
            list = new List<Book>();

            var editorial1 = new Editorial() { Id = 1, Name = "Editorial 1" };

            list.Add(new Book()
            { 
                Id = 1,
                Name = "Libro 1",
                Author = "Krako",
                Editorial = editorial1
            });

            list.Add(new Book()
            { 
                Id = 2,
                Name = "Libro 2",
                Author = "!Krako",
                Editorial = editorial1
            });

            list.Add(new Book()
            { 
                Id = 3,
                Name = "Libro 3",
                Author = "Not Krako",
                Editorial = editorial1
            });
        }
        public List<Book> GetAll()
        {
            return list;
        }

        public Book Get(int id)
        {
            return list.FirstOrDefault(b => b.Id == id);
        }

        public void Save(Book book)
        {
            this.Delete(book.Id);

            list.Add(book);
        }

        public void Delete (int id)
        {
            var book = Get(id);

            if(book != null)
            {
                list.Remove(book);
            }
        }

    }
}