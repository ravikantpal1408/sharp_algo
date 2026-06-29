namespace FacadePattern;

public class NotificationService
{
    public void SendBookingConfirmation(string userEmail) {
        Console.WriteLine("Booking confirmation sent to " + userEmail);
    }
}