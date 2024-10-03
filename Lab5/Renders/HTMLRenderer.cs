namespace Lab5.Renders;

public class HTMLRenderer : IRenderer
{
    public string RenderTitle(string title)
    {
        return $"<h1>{title}</h1>";
    }

    public string RenderContent(string content)
    {
        return $"<p>{content}</p>";
    }
}
