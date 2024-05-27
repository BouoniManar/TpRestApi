using TpRestApi.Models;

namespace TpRestApi.Repositories
{
    public interface ICategoryInterface
    {
        Task<IEnumerable<Categorie> >GetAllCategories();
        Task<Categorie> CreateCategory(Categorie category);
        Task<Categorie> EditCategory(int id, Categorie
       category);
        Task<Categorie> DeleteCategory(int id);
    }
}
