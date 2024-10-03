using Lab5.Renders;

namespace Lab5.Pages;

public class SimplePage : Page
{
    private string _title;
    private string _content;
    private readonly IRenderer _renderer;

    public SimplePage(IRenderer renderer, string title, string content) : base(renderer)
    {
        _renderer = renderer;
        _title = title;
        _content = content;
    }

    public override string Render()
    {
        return _renderer.RenderTitle(_title) + "\n" + _renderer.RenderContent(_content);
    }
}
