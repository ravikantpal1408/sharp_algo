using System;

namespace ProtoType;

public interface IEmailTemplate
{
    IEmailTemplate Clone(); // Replaces Java's Cloneable mechanism
    void SetContent(string content);
    void Send(string to);
}
