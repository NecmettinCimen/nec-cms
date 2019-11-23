using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using NecCms.Database;

namespace NecCms.Logger
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly IHttpContextAccessor _accessor;
        private readonly ILoggerService _genericService;
        private readonly RequestDelegate _next;

        public RequestResponseLoggingMiddleware(RequestDelegate next, ILoggerService genericService,
            IHttpContextAccessor accessor)
        {
            _next = next;
            _genericService = genericService;
            _accessor = accessor;
        }

        public async Task Invoke(HttpContext context)
        {

            if (context.Request.Path.ToString().StartsWith("/images"))
            {
                await _next(context);
            }
            else
            {
                var watch = new Stopwatch();
                watch.Start();
                var logger = new CustomLogger();
                //First, get the incoming request
                logger = await FormatRequest(context.Request);
                logger.RemoteIpAddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
                logger.UserAgent = context.Request.Headers["User-Agent"].ToString();
                
                var statusCode = FormatResponse(context.Response);
                context.Response.OnStarting(() =>
                {
                    // Stop the timer information and calculate the time   
                    watch.Stop();
                    logger.Time = watch.ElapsedMilliseconds;
                    return Task.CompletedTask;
                });

                logger.StatusCode = statusCode;

                await _genericService.SaveLog(logger);
                //Continue down the Middleware pipeline, eventually returning to this class
                await _next(context);
            }
        }

        private async Task<CustomLogger> FormatRequest(HttpRequest request)
        {
            //This line allows us to set the reader for the request back at the beginning of its stream.
            request.EnableRewind();

            //We now need to read the request stream.  First, we create a new byte[] with the same length as the request stream...
            var buffer = new byte[Convert.ToInt32(request.ContentLength)];

            //...Then we copy the entire request stream into the new buffer.
            await request.Body.ReadAsync(buffer, 0, buffer.Length);

            return new CustomLogger
            {
                Path = request.Path,
                QueryString = request.QueryString.HasValue ? request.QueryString.Value : null
            };
        }

        private int FormatResponse(HttpResponse response)
        {
            return response.StatusCode;
        }
    }
}