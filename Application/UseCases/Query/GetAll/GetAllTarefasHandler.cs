using Application.Dto;
using AutoMapper;
using Core.Domain;
using Core.Interfaces;
using MediatR;

namespace Application.UseCases.Query.GetAll;

public class GetAllTarefasHandler : IRequestHandler<GetAllTarefasQuery, IEnumerable<TarefaResponse>>
{
    private readonly ITarefaRepository _tarefaRepository;
    private readonly IMapper _mapper;

    public GetAllTarefasHandler(ITarefaRepository tarefaRepository, IMapper mapper)
    {
        _tarefaRepository = tarefaRepository;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<TarefaResponse>> Handle(GetAllTarefasQuery request, CancellationToken cancellationToken)
    {
        var result = await _tarefaRepository.GetAllAsync();
        return _mapper.Map<List<TarefaResponse>>(result);
    }
}