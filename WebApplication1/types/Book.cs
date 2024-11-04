namespace WebApplication1.types;

public class Book
{
    [DefaultValue("John Doe")]
        [UseToUpper]
    public string Title { get; set; }
    
    public Author Author { get; set; }
    
    [DefaultValue(BookGenre.Fiction)]
    public BookGenre Genre { get; set; }
}

public class Author
{
    [UseToUpper]
    public string Name { get; set; }
}

public enum BookGenre
{
    Fiction,
    NonFiction
}

public class BookGenreType : EnumType<BookGenre>
{
    protected override void Configure(IEnumTypeDescriptor<BookGenre> descriptor)
    {
        descriptor.BindValuesExplicitly();
        descriptor.Value(BookGenre.Fiction).Name("Fiction").Description("Fiction books");
    }
}
