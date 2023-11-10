using CrudApi.DTOS;
using CrudApi.Models;
using CrudApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CrudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        private readonly CategoryRepository _categoryRepository;
        public CategoryController(ProductDBContext dbContext)
        {
            _categoryRepository = new CategoryRepository(dbContext);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] AddCategory addCategory)
        {
            try
            {
                if (addCategory == null)
                {
                    return BadRequest();
                }

                var addCat = await _categoryRepository.CreateCategory(addCategory);
                return Ok(addCat);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
