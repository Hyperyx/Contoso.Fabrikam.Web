namespace Contoso.Fabrikam.Web.Models
{
    public class StoreDatabaseSettings : IStoreDatabaseSettings
    {
        public string BooksCollectionName { get; set; }
        public string MoviesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IStoreDatabaseSettings
    {
        string BooksCollectionName { get; set; }
        string MoviesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}