using HotChocolate.Subscriptions;
using WebApplication1.types;

namespace WebApplication1.Mutations;

public class Mutations
{
    public async Task<Book> AddBook(Book book, ITopicEventSender sender)
    {
        await sender.SendAsync("BookAdded", book);
        
        return book;
    }
}