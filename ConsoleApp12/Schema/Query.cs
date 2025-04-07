using GreenDonut.Data;
using HC_Base.DomainModels;
using HotChocolate.Execution.Processing;

[QueryType]
public class Query
{
    [UseProjection]
    public Book GetBook(QueryContext<Book> context, ISelection selection)
    {
        var selector = selection.AsSelector<Book>();
        Console.WriteLine(selector);
        return new Book
        {
            Title = "C# in depth.",
            Id = 1,
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };
    }
}