namespace FacadePattern;

public class SeatReservationService
{
    public void ReserveSeat(String movieId, String seatNumber) {
        Console.WriteLine("Seat " + seatNumber + " reserved for movie " + movieId);
    }
}