namespace Lab5.Renders;

public class XmlRenderer : IRenderer
{
    public string RenderTitle(string title)
    {
        return $"<title>{title}</title>";
    }

    public string RenderContent(string content)
    {
        return $"<content>{content}</content>";
    }
}
