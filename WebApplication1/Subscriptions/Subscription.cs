using WebApplication1.types;

namespace WebApplication1.Subscriptions;

public class Subscription
{
    [Subscribe]
    [Topic("BookAdded")]
    
    public Book BookAdded([EventMessage] Book book) => book;
}