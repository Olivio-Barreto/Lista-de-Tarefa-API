using Core.Domain;
using MediatR;

namespace Application.UseCases.Query.GetAll;

public record GetAllTarefasQuery : IRequest<List<Tarefa>>;