using App3.Core.Contracts.Services;
using App3.Core.Models;

namespace App3.Core.Services;
public class MediaDataService : IMediaDataService
{
    private readonly List<Media> _media;

    public MediaDataService()
    {
        _media = new List<Media>();
        _media.AddRange(new List<Media>
        {
            new Book { Id = 1, Title = "Lord of the rings", Author="J.R.R Tolkien", Pages=351, ImageUri="https://s1.adlibris.com/images/3673087/the-lord-of-the-rings.jpg" },
            new Movie { Id = 2, Title = "The Godfather", Director="Francis Ford Coppola", Length=175, ImageUri="https://prod-printler-front-as.azurewebsites.net/media/photo/167934-2.jpg?mode=crop&width=725&height=1024&rnd=0.0.1" },
            new Book { Id = 3, Title = "Harry Potter", Author="J.K Rowling", Pages=351, ImageUri="https://m.media-amazon.com/images/I/51zZ3SAulVL._SY445_SX342_.jpg"},
            new Movie { Id = 4, Title = "The Shawshank Redemption", Director="Frank Darabont", Length=175, ImageUri="https://i.ebayimg.com/images/g/ag4AAOSw4CFY3NZF/s-l960.webp" },
            new Book { Id = 5, Title = "The Da Vinci Code", Author="Dan Brown", Pages=351, ImageUri="https://s1.adlibris.com/images/522626/the-da-vinci-code.jpg" },
            new Movie { Id = 6, Title = "The Dark Knight", Director="Christopher Nolan", Length=175, ImageUri="https://i.ebayimg.com/images/g/uFYAAOSwaFViW~IA/s-l960.webp" },
            new Book { Id = 7, Title = "The Alchemist", Author="Paulo Coelho", Pages=351, ImageUri="https://s1.adlibris.com/images/551244/alchemist.jpg" },
            new Movie { Id = 8, Title = "The Lord of the Rings", Director="Peter Jackson", Length=175, ImageUri="https://m.media-amazon.com/images/I/71FKDTzfGfL.__AC_SX300_SY300_QL70_ML2_.jpg" }
        });
    }
    public async Task<IEnumerable<Media>> GetAllMedia() => await Task.FromResult(_media.ToList());
    public async Task<Media> GetMediaByIdAsync(int id) => await Task.FromResult(_media.FirstOrDefault(p => p.Id == id));
    public async Task<IEnumerable<Book>> GetBooksAsync() => await Task.FromResult(_media.OfType<Book>().ToList());
    public async Task<IEnumerable<Movie>> GetMoviesAsync() => await Task.FromResult(_media.OfType<Movie>().ToList());
    public async Task AddBookAsync(string title, string author, int pages, string imageUrl) => await Task.Factory.StartNew(() => {
        _media.Add(new Book { Id = _media.Max(x => x.Id) + 1, Title = title, Author = author, Pages = pages, ImageUri = imageUrl });
    });
    public async Task AddMovieAsync(string title, string director, int length, string imageUri) => await Task.Factory.StartNew(() =>
    {
        _media.Add(new Movie { Id = _media.Max(x => x.Id) + 1, Title = title, Director = director, Length = length, ImageUri = imageUri });
    });
}
