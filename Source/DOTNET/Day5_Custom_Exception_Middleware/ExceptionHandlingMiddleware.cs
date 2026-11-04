using LearnDotNet.Source.Day2_RESTFulAPIs;
using System.Net;
using System.Text.Json;

namespace LearnDotNet.Source.Day5_Custom_Exception_Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware( RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next; 
            _logger = logger;
        }


        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError; // 500

            // use wrapper apiresponse (day2)
            var response = ApiResponse<object>.ReponseFailed(statusCode: 500, errorCode: "INTERNAL_SERVER_ERROR", message: "Having problem in system, error is: " + exception.Message);
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var jsonResponse = JsonSerializer.Serialize(response, options);

            await context.Response.WriteAsync(jsonResponse);
        }



        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // accept for request continue move to controller:
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Having one problem: {Message}", ex.Message);
                await HandleExceptionAsync(context, ex);
            }
        }
    }
}
