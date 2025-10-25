using Application.Dto;
using AutoMapper;
using Core.Interfaces;
using MediatR;

namespace Application.UseCases.Query.GetByName;

public class GetByNameHandler : IRequestHandler<GetByNameQuery, TarefaResponse>
{
    private readonly ITarefaRepository _tarefaRepository;
    private readonly IMapper _mapper;

    public GetByNameHandler(ITarefaRepository tarefaRepository,  IMapper mapper)
    {
        _tarefaRepository = tarefaRepository;
        _mapper = mapper;
    }
    
    public async Task<TarefaResponse> Handle(GetByNameQuery request, CancellationToken cancellationToken)
    {
        var result = await _tarefaRepository.GetByNameAsync(request.Name);
        return _mapper.Map<TarefaResponse>(result);
    }
}