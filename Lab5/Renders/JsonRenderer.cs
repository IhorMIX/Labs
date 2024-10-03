namespace Lab5.Renders;

public class JsonRenderer : IRenderer
{
    public string RenderTitle(string title)
    {
        return $"{{\"title\": \"{title}\"}}";
    }

    public string RenderContent(string content)
    {
        return $"{{\"content\": \"{content}\"}}";
    }
}
