using Lab5.Renders;

namespace Lab5.Pages;

public abstract class Page
{
    private readonly IRenderer _renderer;

    public Page(IRenderer renderer)
    {
        _renderer = renderer;
    }

    public abstract string Render();
}
