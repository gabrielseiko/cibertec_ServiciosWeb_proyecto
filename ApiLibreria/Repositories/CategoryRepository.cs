using ApiLibreria.DbContexts;
using ApiLibreria.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLibreria.Repositories
{
    public class CategoryRepository:ICategoryRepository
    {

        private readonly AppDbContext dbContext;
        public CategoryRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Category> CreateCategory(Category category)
        {
            dbContext.Categories.Add(category);
            await dbContext.SaveChangesAsync();
            return category;
        }

        public async Task<bool> DeleteCategory(string IdCategory)
        {
            var category = await dbContext.Categories.FirstOrDefaultAsync(p => p.IdCategory == IdCategory);
            if (category == null)
            {
                return false;
            }
            dbContext.Categories.Remove(category);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await dbContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryById(string IdCategory)
        {
            var category = await dbContext.Categories.Where(p => p.IdCategory == IdCategory).FirstOrDefaultAsync();
            return category;
        }

        public async Task<Category> UpdateCategory(Category category)
        {
            dbContext.Categories.Update(category);
            await dbContext.SaveChangesAsync();
            return category;
        }
    }
}
