namespace FacadePattern;

public class TicketService
{
    public void GenerateTicket(string movieId, string seatNumber) {
        Console.WriteLine("Ticket generated for movie " + movieId + ", Seat: " + seatNumber);
    }
}