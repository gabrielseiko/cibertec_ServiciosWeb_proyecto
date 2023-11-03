using ApiCategory.Models;
using ApiCategory.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiCategory.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CategoryController:ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]
        [Route("GetCategories")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return StatusCode(StatusCodes.Status200OK, await categoryRepository.GetCategories());
        }

        [HttpGet]
        [Route("GetCategories/page/{page}/size/{size}")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories(int page, int size)
        {
            return StatusCode(StatusCodes.Status200OK, await categoryRepository.GetCategories(page, size));
        }

        [HttpGet]
        [Route("GetCategoryById/{idCategory}")]
        public async Task<ActionResult<Category>> GetCategoryById(string idCategory)
        {
            return StatusCode(StatusCodes.Status200OK, await categoryRepository.GetCategoryById(idCategory));
        }

        [HttpPost]
        [Route("CreateCategory")]
        public async Task<ActionResult<Category>> CreateCategory(Category category)
        {
            return StatusCode(StatusCodes.Status201Created, await categoryRepository.CreateCategory(category));
        }


        [HttpPut]
        [Route("UpdateCategory")]
        public async Task<ActionResult<Category>> UpdateCategory(Category category)
        {
            return StatusCode(StatusCodes.Status200OK, await categoryRepository.UpdateCategory(category));
        }

        [HttpDelete]
        [Route("DeleteCategory")]
        public async Task<ActionResult<bool>> DeleteCategory(string idCategory)
        {
            return StatusCode(StatusCodes.Status200OK, await categoryRepository.DeleteCategory(idCategory));
        }
    }
}
