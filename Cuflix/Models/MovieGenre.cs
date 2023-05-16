namespace Cuflix.Models;
public class MovieGenre
{
     public int MovieId { get; set; }

     public Movie Movie { get; set; }

     public byte GenreId { get; set; }
     public Genre Genre { get; set; }
}
