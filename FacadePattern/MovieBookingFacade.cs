namespace FacadePattern;

public class MovieBookingFacade
{
    private readonly PaymentService _paymentService;
    private readonly SeatReservationService _seatReservationService;
    private readonly NotificationService _notificationService;
    private readonly LoyaltyPointsService _loyaltyPointsService;
    private readonly TicketService _ticketService;

    // Constructor to initialize all the subsystem services.
    public MovieBookingFacade() {
        _paymentService = new PaymentService();
        _seatReservationService = new SeatReservationService();
        _notificationService = new NotificationService();
        _loyaltyPointsService = new LoyaltyPointsService();
        _ticketService = new TicketService();
    }

    // Method providing a simplified interface for booking a movie ticket
    public void BookMovieTicket(string accountId, string movieId, string seatNumber, string userEmail, double amount) {
        _paymentService.MakePayment(accountId, amount);
        _seatReservationService.ReserveSeat(movieId, seatNumber);
        _ticketService.GenerateTicket(movieId, seatNumber);
        _loyaltyPointsService.AddPoints(accountId, 50);
        _notificationService.SendBookingConfirmation(userEmail);

        // Indicate successful completion of the entire booking process.
        Console.WriteLine("Movie ticket booking completed successfully!");
    }
}