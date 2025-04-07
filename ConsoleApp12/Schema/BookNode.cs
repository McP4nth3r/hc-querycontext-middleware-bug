using HC_Base.DomainModels;

namespace HC_Base.Schema;

[ObjectType<Book>]
public static partial class BookNode
{
    static partial void Configure(IObjectTypeDescriptor<Book> descriptor)
    {
        descriptor.BindFieldsExplicitly();
        descriptor.Field(b => b.Title);
        descriptor.Field(b => b.Id);
        descriptor.Field(b => b.Author);
    }
}