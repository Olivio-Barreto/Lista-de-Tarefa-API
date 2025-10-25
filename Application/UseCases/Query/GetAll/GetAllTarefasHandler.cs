using Core.Domain;
using Core.Interfaces;
using MediatR;

namespace Application.UseCases.Query.GetAll;

public class GetAllTarefasHandler : IRequestHandler<GetAllTarefasQuery, IEnumerable<Tarefa>>
{
    private readonly ITarefaRepository _tarefaRepository;

    public GetAllTarefasHandler(ITarefaRepository tarefaRepository)
    {
        _tarefaRepository = tarefaRepository;
    }
    
    public async Task<IEnumerable<Tarefa>> Handle(GetAllTarefasQuery request, CancellationToken cancellationToken)
    {
        return await _tarefaRepository.GetAll();
    }
}