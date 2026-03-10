namespace LearningSharp;

public class InterfaceMCQ: ITwo, IOne
{
    public InterfaceMCQ()
    {
        
    }
}

public interface IOne
{
    void Show() { Console.WriteLine("Interface MCQ One"); }
}

public interface ITwo
{
    void Show() { Console.WriteLine("Interface MCQ Two"); }
}