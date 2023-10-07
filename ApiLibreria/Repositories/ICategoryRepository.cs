using ApiLibreria.Models;

namespace ApiLibreria.Repositories
{
    public interface ICategoryRepository
    {
        //CRUD
        public Task<IEnumerable<Category>> GetCategories();
        public Task<Category> GetCategoryById(string IdCategory);
        public Task<Category> CreateCategory(Category category);
        public Task<Category> UpdateCategory(Category category);    
        public Task<bool> DeleteCategory(string IdCategory); 
    }
}
