# Demo: `QueryContext<T>` Bug in HotChocolate with Middleware

This is a demo showcasing a bug in HotChocolate. When a middleware is applied to the pipeline, the `QueryContext` for projections is empty.

### How to Reproduce

1. Clone the repository
2. Run the project
3. Open Nitro at [http://localhost:5000/graphql/](http://localhost:5000/graphql/)
4. Execute the following query:

```graphql
query {
    book {
        title
        id
        author {
            name
        }
    }
}
```

### Behavior

When the line ``.UseField<MaintenanceModeMiddleware>();`` in `Program.cs` is not commented out, the console output is:

```
root => new Book() { Id = root.Id }
```

### Expected Behavior (regardless of middleware)

```
root => new Book() {
    Title = root.Title,
    Id = root.Id,
    Author = new Author() {
        Name = IIF((root.Author.Name == null), null, root.Author.Name)
    }
}
```