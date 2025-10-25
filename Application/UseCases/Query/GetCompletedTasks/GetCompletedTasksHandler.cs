using Application.Dto;
using AutoMapper;
using Core.Interfaces;
using MediatR;

namespace Application.UseCases.Query.GetCompletedTasks;

public class GetCompletedTasksHandler : IRequestHandler<GetCompletedTasksQuery, List<TarefaResponse>>
{
    private readonly ITarefaRepository _tarefaRepository;
    private readonly IMapper _mapper;

    public GetCompletedTasksHandler(ITarefaRepository tarefaRepository, IMapper mapper)
    {
        _tarefaRepository = tarefaRepository;
        _mapper = mapper;
    }
    
    public async Task<List<TarefaResponse>> Handle(GetCompletedTasksQuery request, CancellationToken cancellationToken)
    {
        var result = await _tarefaRepository.GetCompletedTasksAsync(cancellationToken);
        return _mapper.Map<List<TarefaResponse>>(result);
    }
}