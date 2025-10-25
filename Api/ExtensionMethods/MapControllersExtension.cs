using Application.UseCases.Commands.Create;
using Application.UseCases.Commands.Delete;
using Application.UseCases.Commands.Update;
using Application.UseCases.Query.GetAll;
using Application.UseCases.Query.GetByName;
using Application.UseCases.Query.GetCompletedTasks;
using Application.UseCases.Query.GetUnCompletedTasks;
using MediatR;

namespace Api.ExtensionMethods;

public static class MapControllersExtension
{
    public static void MapEndPoints(this IEndpointRouteBuilder  endpoints)
    {
        var group = endpoints.MapGroup("v1");
        
        group.MapGet("/", async (IMediator mediator, GetAllTarefasQuery query) =>
        {
            var result = await mediator.Send(query);
            return Results.Ok(result);
        });

        group.MapGet("/GetCompletedTasks", async (IMediator mediator, GetCompletedTasksQuery query) =>
        {
            var result = await mediator.Send(query);
            return Results.Ok(result);
        });

        group.MapGet("/GetUnCompletedTasks", async (IMediator mediator, GetUnCompletedTasksQuery query) =>
        {
            var result = await mediator.Send(query);
            return Results.Ok(result);
        });

        group.MapGet("/GetTaskByName", async (IMediator mediator, GetByNameQuery query) =>
        {
            var result = await mediator.Send(query);
            return Results.Ok(result);
        });

        group.MapPost("/Create", async (IMediator mediator, CreateTarefaCommand command) =>
        {
            var result = await mediator.Send(command);
            return Results.Created("", result);
        });
        
        group.MapPatch("/UpdateTask", async (IMediator mediator, UpdateTarefaCommand command) =>
        {
            var result = await mediator.Send(command);
            return Results.Ok(result);
        });

        group.MapDelete("/DeleteTask", async (IMediator mediator, DeleteTarefaCommand command) =>
        {
            var result = await mediator.Send(command);
            return Results.Ok(result);
        });
    }
}