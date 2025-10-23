using Application.Dto;
using AutoMapper;
using Core.Domain;
using Core.Interfaces;
using MediatR;

namespace Application.UseCases.Commands.Create;

public class CreateTarefaHandler : IRequestHandler<CreateTarefaCommand, TarefaResponse>
{
    private readonly ITarefaRepository _tarefaRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public CreateTarefaHandler(ITarefaRepository  tarefaRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _tarefaRepository = tarefaRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<TarefaResponse> Handle(CreateTarefaCommand request, CancellationToken cancellationToken)
    {
        var tarefa = _mapper.Map<Tarefa>(request);
        _tarefaRepository.Create(tarefa);
         await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<TarefaResponse>(tarefa);
    }
}