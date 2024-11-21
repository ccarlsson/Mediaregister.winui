using App3.Core.Models;

namespace App3.Core.Contracts.Services;
public interface IMediaDataService
{
    Task<IEnumerable<Media>> GetAllMedia();
    Task<Media> GetMediaByIdAsync(int id);
    Task<IEnumerable<Book>> GetBooksAsync();
    Task<IEnumerable<Movie>> GetMoviesAsync();
    Task AddBookAsync(string title, string author, int pages, string imageUrl);
    Task AddMovieAsync(string title, string director, int length, string imageUri);
}
