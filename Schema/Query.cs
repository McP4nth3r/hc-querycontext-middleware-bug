using ConsoleApp12.DomainModels;
using GreenDonut.Data;
using HotChocolate.Execution.Processing;

namespace ConsoleApp12.Schema;

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