using HotChocolate.Resolvers;

namespace ConsoleApp12.Schema;

public class MaintenanceModeMiddleware
{
    private readonly FieldDelegate _next;

    public MaintenanceModeMiddleware(FieldDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(IMiddlewareContext context)
    {
        await _next(context)
            .ConfigureAwait(false);
    }
}