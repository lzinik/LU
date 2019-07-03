using ej_backend.Model;
using System.Collections.Generic;

namespace ej_backend.Services
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book Get(int id);
        void Save(Book book);
        void Delete (int id);
    }
}