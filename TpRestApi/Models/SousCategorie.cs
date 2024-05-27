namespace TpRestApi.Models
{
    public class SousCategorie
    {
        public int Id { get; set; }
        string Name { get; set; }
        public Categorie Categorie { get; set; }
    }
}
