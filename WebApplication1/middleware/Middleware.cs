using HotChocolate.Resolvers;

namespace eShop.Catalog.Types.Configuration;

public class Middleware
{
    private readonly FieldDelegate _next;

    public Middleware(FieldDelegate next)
    {
        _next = next;
    }
    
    public async ValueTask InvokeAsync(IMiddlewareContext context)
    {
        Console.WriteLine("Middleware executing...");
        
        await _next(context);
    }
}