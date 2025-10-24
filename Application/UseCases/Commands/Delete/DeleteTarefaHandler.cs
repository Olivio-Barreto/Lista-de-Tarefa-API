using Application.Dto;
using AutoMapper;
using Core.Interfaces;
using MediatR;

namespace Application.UseCases.Commands.Delete;

public class DeleteTarefaHandler : IRequestHandler<DeleteTarefaCommand, TarefaResponse>
{
    private readonly ITarefaRepository _tarefaRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public DeleteTarefaHandler(ITarefaRepository tarefaRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _tarefaRepository = tarefaRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async Task<TarefaResponse> Handle(DeleteTarefaCommand request, CancellationToken cancellationToken)
    {
        var tarefa = await _tarefaRepository
            .GetByNameAsync(request.Name) ?? throw new ArgumentNullException(nameof(request), "Tarefa not found");
        
        _tarefaRepository.Delete(tarefa);
        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<TarefaResponse>(tarefa);
    }
}