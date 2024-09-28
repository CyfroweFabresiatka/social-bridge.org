using System.Diagnostics.CodeAnalysis;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace SocialBridge.Main.Extensions
{
    public static class EndpointConventionBuilderExtensions
    {
        public static TBuilder WithOpenApiDescription<TBuilder>(this TBuilder builder, string description, string? summary = null)
            where TBuilder : IEndpointConventionBuilder
        {
            return builder.WithOpenApi(operation =>
                new OpenApiOperation(operation)
                {
                    Description = description,
                    Summary = summary ?? description,
                });
        }

        public static RouteHandlerBuilder MapGet<TRequest>(this IEndpointRouteBuilder api, [StringSyntax("Route")] string pattern)
            where TRequest : IRequest<IResult> =>
            api.MapGet(pattern, ([AsParameters] TRequest query, IMediator mediator) => mediator.Send(query));

        public static RouteHandlerBuilder MapPost<TRequest>(this IEndpointRouteBuilder api, [StringSyntax("Route")] string pattern)
            where TRequest : IRequest<IResult> =>
            api.MapPost(pattern, ([FromBody] TRequest cmd, IMediator mediator) => mediator.Send(cmd));

        public static RouteHandlerBuilder MapDelete<TRequest>(this IEndpointRouteBuilder api, [StringSyntax("Route")] string pattern)
            where TRequest : IRequest<IResult> =>
            api.MapDelete(pattern, ([AsParameters] TRequest query, IMediator mediator) => mediator.Send(query));
    }
}
