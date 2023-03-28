namespace CarPolicy.Common.Api.Middlewares
{
    using CarPolicy.Infrastructure.Messages;
    using Dtos.Common;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Http.Features;
    using Microsoft.AspNetCore.Routing;
    using Newtonsoft.Json;
    using System;
    using System.Net;
    using System.Runtime.ConstrainedExecution;
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    public class ErrorMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorMiddleware( RequestDelegate next )
        {
            this._next = next;
        }

        public async Task Invoke( HttpContext context)
        {
            try
            {
                await this._next( context );
            }
            catch( Exception ex )
            {
                await GetResult( ex, context );
            }
        }

        private static async Task GetResult(Exception exception, HttpContext context)
        {
            if (exception is CustomBadRequestException badRequestException)
            {
                await GetResult(context, badRequestException, HttpStatusCode.BadRequest);
            }
            else if (exception is CustomNotFoundException notFoundException)
            {
                await GetResult(context, notFoundException, HttpStatusCode.NotFound);
            }
            else if (exception is CustomUnAuthorizedException unAuthorizedException)
            {
                await GetResult(context, unAuthorizedException, HttpStatusCode.Unauthorized);
            }
            else
            {
                await GetResult(context, HttpStatusCode.Conflict);
            }
        }

        private static async Task GetResult( HttpContext context, HttpStatusCode code )
        {
            var result = new ErrorResponse( "Not message defined", (int)code);
            Clear(context, code);

            await context.Response.WriteAsync(JsonConvert.SerializeObject(result));
        }

        private static async Task GetResult(HttpContext context, ModelBaseException exception, HttpStatusCode code)
        {
            var result = new ErrorResponse( exception.ApplicationMessage?.Message, (int)code );
            Clear(context, code);

            await context.Response.WriteAsync(JsonConvert.SerializeObject(result));
        }

        private static HttpContext Clear(HttpContext context, HttpStatusCode code)
        {
            context.Response.StatusCode = 200;
            context.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = null;
            context.Response.Headers.Clear();
            if (context.Response.Body.CanSeek)
            {
                context.Response.Body.SetLength(0L);
            }

            context.Response.StatusCode = (int)code;
            context.Response.ContentType = @"application/json";

            return context;
        }
    }
}
