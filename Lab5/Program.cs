using Lab5.Entity;
using Lab5.Pages;
using Lab5.Renders;

Product product = new Product
{
    Name = "Google Pixel",
    Description = "High-performance smartphone",
    Id = 1,
    Image = "google_pixel.png"
};

IRenderer htmlRenderer = new HTMLRenderer();
IRenderer jsonRenderer = new JsonRenderer();
IRenderer xmlRenderer = new XmlRenderer();

Page simplePage = new SimplePage(htmlRenderer, "Simple Page", "This is a simple page.");
Page simplePage2 = new SimplePage(xmlRenderer, "Simple Page", "This is a simple page.");
Page productPage = new ProductPage(jsonRenderer, product);

Console.WriteLine(simplePage.Render());
Console.WriteLine(simplePage2.Render());
Console.WriteLine(productPage.Render());
