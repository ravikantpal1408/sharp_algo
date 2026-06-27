using System;

namespace ProtoType;

public class EmailTemplateRegistry
{
    private static readonly Dictionary<string, IEmailTemplate> Template = new();

    static EmailTemplateRegistry()
    {
        Template.Add("welcome", new EmailTemplate());

    }

    public static IEmailTemplate GetTemplate(string type)
    {
        if (Template.TryGetValue(type, out var template))
        {
            return template.Clone(); // clone to avoid modifying original registry instance
        }
        throw new KeyNotFoundException($"Template type '{type}' was not found.");
    }
}
