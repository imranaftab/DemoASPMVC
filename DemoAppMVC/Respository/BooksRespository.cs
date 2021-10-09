using DemoAppMVC.DAL;
using DemoAppMVC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAppMVC.Respository
{
    public class BooksRespository : IBooksRespository
    {
        private DemoDBContext _db;
        public BooksRespository(DemoDBContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<BooksEntity>> GetAllBooksAsync()
        {
            return await Task.FromResult<IEnumerable<BooksEntity>>( _db.Books.ToList());
        }

        public async Task SaveBooksAsync(BooksEntity book)
        {
            var books = _db.Books;
            books.Add(book);

            await _db.SaveChangesAsync();
        }
    }
}
