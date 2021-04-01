using Contoso.Fabrikam.Web.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Contoso.Fabrikam.Web.Services
{
    public class MovieService
    {
        private readonly IMongoCollection<Movie> _movies;

        public MovieService(IStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _movies = database.GetCollection<Movie>(settings.MoviesCollectionName);
        }

        public List<Movie> Get() =>
            _movies.Find(movie => true).ToList();

        public Movie Get(string id) =>
            _movies.Find<Movie>(movie => movie.Id == id).FirstOrDefault();

        public Movie Create(Movie movie)
        {
            _movies.InsertOne(movie);
            return movie;
        }

        public void Update(string id, Movie movieIn) =>
            _movies.ReplaceOne(movie => movie.Id == id, movieIn);

        public void Remove(string id) => 
            _movies.DeleteOne(movie => movie.Id == id);
    }
}