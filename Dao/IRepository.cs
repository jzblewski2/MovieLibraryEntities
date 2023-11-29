using MovieLibraryEntities.Models;

namespace MovieLibraryEntities.Dao
{
    public interface IRepository
    {
        IEnumerable<Movie> GetAll();
        IEnumerable<Movie> Search(string searchString);
        List<Movie> FindMovie(string title);
        Movie GetById(int id);
        Movie GetByTitle(string title);
    }
}
