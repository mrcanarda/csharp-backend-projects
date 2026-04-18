public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception)
        {
          context.Response.StatusCode = 500; 
          context.Response.ContentType = "application/json"; 

          var response = new
          {
              error = "Internal server error"
          }; 

          var json = System.Text.Json.JsonSerializer.Serialize(response); 

          await context.Response.WriteAsync(json);
        }
    }
}