using ApiCategory.DbContexts;
using ApiCategory.Exceptions;
using ApiCategory.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCategory.Repositories
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

        public async Task<bool> DeleteCategory(string idCategory)
        {
            var category = await dbContext.Categories.FirstOrDefaultAsync(c => c.IdCategory == idCategory);
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

        public async Task<IEnumerable<Category>> GetCategories(int page, int size)
        {
            var result = await dbContext.Categories
                .Skip(page * size)
                .Take(size)
                .ToListAsync();
            if (result == null)
            {
                throw new Exception();
            }
            else if (result.Count == 0)
            {
                throw new NotFoundException("Category list is empty");
            }
            return result;
        }

        public async Task<Category> GetCategoryById(string idCategory)
        {
            var category = await dbContext.Categories.Where(c => c.IdCategory == idCategory).FirstOrDefaultAsync();
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
