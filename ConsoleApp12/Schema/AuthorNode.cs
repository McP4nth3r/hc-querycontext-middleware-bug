using HC_Base.DomainModels;

namespace HC_Base.Schema;

[ObjectType<Author>]
public static partial class AuthorNode
{
    static partial void Configure(IObjectTypeDescriptor<Author> descriptor)
    {
        descriptor.BindFieldsExplicitly();
        descriptor.Field(a => a.Name)
            .Type<NonNullType<StringType>>();
    }
}