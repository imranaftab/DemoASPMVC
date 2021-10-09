using DemoAppMVC.DAL;
using DemoAppMVC.Interfaces;
using DemoAppMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAppMVC.Services
{
    public class BooksService : IBooksService
    {
        private IBooksRespository _books;

        public BooksService(IBooksRespository books)
        {
            _books = books;
        }
        public async Task<IEnumerable<BooksViewModel>> GetAllBooksAsync()
        {
            IEnumerable<BooksViewModel> booksViewModel = null;
            try
            {
                var books = await _books.GetAllBooksAsync();
                booksViewModel = books.Select(r => 
                new BooksViewModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    Price = r.Price,
                    Quantity = r.Quantity
                });

            }
            catch (Exception ex)
            {
                // Todo: Add exception here
            }
            
            return booksViewModel;
        }

        public async Task SaveBookAsync(BooksViewModel book)
        {
            var be = new BooksEntity
            {
                Name = book.Name,
                Price = book.Price,
                Quantity = book.Quantity
            };

            await _books.SaveBooksAsync(be);
        }
    }
}
