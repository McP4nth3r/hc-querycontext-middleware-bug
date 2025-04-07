namespace HC_Base.DomainModels;

public class Book
{
    public string Title { get; set; }

    public int Id { get; set; }

    public Author Author { get; set; }
}