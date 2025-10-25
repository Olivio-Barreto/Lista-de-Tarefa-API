using Application.Dto;
using AutoMapper;
using Core.Interfaces;
using MediatR;

namespace Application.UseCases.Query.GetUnCompletedTasks;

public class GetUnCompletedTasksHandler : IRequestHandler<GetUnCompletedTasksQuery, List<TarefaResponse>>
{
    private readonly ITarefaRepository _tarefaRepository;
    private readonly IMapper _mapper;

    public GetUnCompletedTasksHandler(ITarefaRepository tarefaRepository, IMapper mapper)
    {
        _tarefaRepository = tarefaRepository;
        _mapper = mapper;
    }
    
    public async Task<List<TarefaResponse>> Handle(GetUnCompletedTasksQuery request, CancellationToken cancellationToken)
    {
        var result = await _tarefaRepository.GetUnCompletedTasksAsync(cancellationToken);
        return _mapper.Map<List<TarefaResponse>>(result);
    }
}