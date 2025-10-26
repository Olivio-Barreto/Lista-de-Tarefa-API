using Application.Dto;
using AutoMapper;
using Core.Interfaces;
using MediatR;

namespace Application.UseCases.Commands.Update;

public class UpdateTarefaHandler : IRequestHandler<UpdateTarefaCommand, TarefaResponse>
{
    private readonly ITarefaRepository _tarefaRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateTarefaHandler(ITarefaRepository tarefaRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _tarefaRepository = tarefaRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async Task<TarefaResponse> Handle(UpdateTarefaCommand request, CancellationToken cancellationToken)
    {
        var list = await _tarefaRepository.GetAllAsync();
        var tarefa = list
            .FirstOrDefault(x => x.Id == request.Id) ?? 
                     throw new ArgumentNullException(nameof(request),  "Tarefa not found");
        
        if (list.FirstOrDefault(x => x.Id != tarefa.Id && x.Name.Equals(request.Name, StringComparison.CurrentCultureIgnoreCase)) != null) 
            throw new InvalidOperationException("Tarefa Existed.");
            
        tarefa.SetName(request.Name ?? tarefa.Name);
        tarefa.SetDescription(request.Description ?? tarefa.Description!);
        
        if (request.IsCompleted == true) 
            tarefa.Complete();

        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<TarefaResponse>(tarefa);
    }
}