using ApiCategory.Models;

namespace ApiCategory.Repositories
{
    public interface ICategoryRepository
    {
        //CRUD
        public Task<IEnumerable<Category>> GetCategories();
        public Task<IEnumerable<Category>> GetCategories(int page, int size);
        public Task<Category> GetCategoryById(string idCategory);
        public Task<Category> CreateCategory(Category category);
        public Task<Category> UpdateCategory(Category category);    
        public Task<bool> DeleteCategory(string idCategory); 
    }
}
