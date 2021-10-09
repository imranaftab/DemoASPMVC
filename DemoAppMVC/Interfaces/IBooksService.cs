using DemoAppMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAppMVC.Interfaces
{
    public interface IBooksService
    {
        Task<IEnumerable<BooksViewModel>> GetAllBooksAsync();
        Task SaveBookAsync(BooksViewModel viewModel);
    }

}
