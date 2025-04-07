using HotChocolate.Resolvers;

namespace HC_Base.Schema;

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