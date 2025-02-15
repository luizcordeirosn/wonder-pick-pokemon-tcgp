using System.Net;

public class GlobalErrorHandling
{
    private readonly RequestDelegate _next;
    private readonly ILogger<GlobalErrorHandling> _logger;

    public GlobalErrorHandling(RequestDelegate next, ILogger<GlobalErrorHandling> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);  // Chama o próximo middleware na pipeline
        }
        catch (Exception ex)
        {
            _logger.LogError($"Something went wrong: {ex.Message}");
            await HandleExceptionAsync(httpContext, ex);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

        var response = new
        {
            message = "An error occurred while processing your request.",
            details = exception.Message
        };

        return context.Response.WriteAsJsonAsync(response);
    }
}