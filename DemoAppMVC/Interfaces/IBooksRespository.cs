using DemoAppMVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAppMVC.Interfaces
{
    public interface IBooksRespository
    {
        public Task<IEnumerable<BooksEntity>> GetAllBooksAsync();
        public Task SaveBooksAsync(BooksEntity booksEntity);
    }
}
