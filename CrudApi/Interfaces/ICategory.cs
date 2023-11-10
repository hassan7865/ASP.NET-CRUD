using CrudApi.DTOS;
using CrudApi.Models;

namespace CrudApi.Interfaces
{
    public interface ICategory
    {
        Task<Category> CreateCategory(AddCategory category);
    }
}
