using CrudApi.DTOS;
using CrudApi.Interfaces;
using CrudApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudApi.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly ProductDBContext dbContext;

        public CategoryRepository(ProductDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Category> CreateCategory(AddCategory category)
        {
            try
            {
                var newCat = new Category
                {
                    Categoryid = Guid.NewGuid(),
                    Categoryname = category.Categoryname,
                    Createdat = DateTime.Now,
                };
                dbContext.Categories.Add(newCat);
                await dbContext.SaveChangesAsync();
                return newCat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
