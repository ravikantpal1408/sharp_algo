using System;

namespace ProtoType;

public class EmailTemplate : IEmailTemplate
{
    private string _content;
    private string _subject;

    public EmailTemplate()
    {
        _content = "Hi there I am bing bing biglo";
        _subject = "Welcome to DSA by TYF";
    }

    public IEmailTemplate Clone()
    {
        return (IEmailTemplate)this.MemberwiseClone();
    }

    public void Send(string to)
    {
        Console.WriteLine($"Sending to {to}: [{_subject}] {_content}");
    }

    public void SetContent(string content)
    {
        _content = content;
    }
}
