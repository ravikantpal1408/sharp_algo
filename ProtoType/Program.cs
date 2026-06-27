using ProtoType;

namespace ProtoTYpe;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("------------- ProtoType ---------------");
        IEmailTemplate emailTemplate = EmailTemplateRegistry.GetTemplate("welcome");
        emailTemplate.SetContent("Hi all i am on sick pto");
        emailTemplate.Send("test@gmail.com");
    }
}