using Microsoft.EntityFrameworkCore;
using TpRestApi.Models;
using TpRestApi.Repositories;

namespace TpRestApi.Services
{
    public class CategoryService : ICategoryInterface
    {
        private readonly ApplicationDbContext _db;
        public CategoryService(ApplicationDbContext _db)
        {
            this._db = _db;
        }
        public async Task<Categorie> CreateCategory(Categorie
       category)
        {
            _db.categorie.Add(category);
            await _db.SaveChangesAsync();
            return category;
        }
        public async Task<Categorie> DeleteCategory(int id)
        {
            var catIndB = await _db.categorie.FindAsync(id);
            _db.categorie.Remove(catIndB);
            await _db.SaveChangesAsync();
            return catIndB;
        }
        public async Task<Categorie> EditCategory(int id,
       Categorie category)
        {
            var catInDb = await _db.categorie.FindAsync(id);
            catInDb.CategoryName = category.CategoryName;
            await _db.SaveChangesAsync();
            return catInDb;
        }
        public async Task<IEnumerable<Categorie>>
       GetAllCategories()
        {
            var cat = await _db.categorie.ToListAsync();
            return cat;
        }
    }
}
    

