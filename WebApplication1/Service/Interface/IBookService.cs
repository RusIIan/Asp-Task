using WebApplication1.Data.Entites;

namespace WebApplication1.Service.Interface
{
    public interface IBookService
    {
        Task<List<Book>> GetAll();
        Task<Book> GetId(int id);
        Task<bool> Create(string bookName, decimal price, string category);
        Task<bool> Update(int id, decimal price, string bookName, string category);
        Task<bool> Delete(int id);
    }
}
