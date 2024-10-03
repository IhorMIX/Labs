using Lab5.Entity;
using Lab5.Renders;

namespace Lab5.Pages;

public class ProductPage : Page
{
    private readonly Product _product;
    private readonly IRenderer _renderer;

    public ProductPage(IRenderer renderer, Product product) : base(renderer)
    {
        _product = product;
        _renderer = renderer;
    }

    public override string Render()
    {
        return _renderer.RenderTitle(_product.Name) + "\n" +
               _renderer.RenderContent(_product.Description) + "\n" +
               _renderer.RenderContent($"Product ID: {_product.Id}") + "\n" +
               _renderer.RenderContent($"Image: {_product.Image}");
    }
}
