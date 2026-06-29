namespace FacadePattern;

public abstract class Program
{
    public static void Main(String[] args)
    {
        MovieBookingFacade movieBookingFacade = new MovieBookingFacade();
        movieBookingFacade.BookMovieTicket("user123", "movie456", "A10", "user@example.com", 500);
    }
}

