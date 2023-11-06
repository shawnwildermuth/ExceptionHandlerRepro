using Microsoft.AspNetCore.Diagnostics;

namespace ExHandler;

public class GlobalExceptionHandler : IExceptionHandler
{
  public async ValueTask<bool> TryHandleAsync(HttpContext httpContext,
    Exception exception,
    CancellationToken cancellationToken)
  {
    httpContext.Response.ContentType = "text/plain";
    httpContext.Response.StatusCode = 501;
    await httpContext.Response.WriteAsync($"It don't work: {exception.Message}");
    return true;
  }
}
