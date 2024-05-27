namespace TpRestApi.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public IEnumerable<SousCategorie> sousCategories { get; set; }
    }
}
