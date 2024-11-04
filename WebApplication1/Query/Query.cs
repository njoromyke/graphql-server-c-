using eShop.Catalog.Types.Configuration;
using WebApplication1.types;

namespace WebApplication1.Query;

public class Query
{
    [UseMiddleware]
    public Book GetBook()
    {
        return new Book()
        {
            Author = new Author()
            {
                Name = "Michael Crichton"
            },
            Title = "Jurassic Park",
            Genre = BookGenre.Fiction
            
            
        };
        
    }
}