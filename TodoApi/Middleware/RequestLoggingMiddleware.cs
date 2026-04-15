namespace TodoApi.Middleware; 

public class RequestLoggingMiddleware
{
    private readonly RequestDelegate _next; 

    public RequestLoggingMiddleware(RequestDelegate next)
    {
        _next = next; 
    }   

  public async Task InvokeAsync(HttpContext context)
{
    Console.WriteLine($"[LOG] {context.Request.Method} {context.Request.Path} - {DateTime.Now}");

    // Remove the comment
    await _next(context);
}

}