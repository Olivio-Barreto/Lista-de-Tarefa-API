using FluentValidation;

namespace Application.UseCases.Commands.Delete;

public class DeleteTarefaValidator : AbstractValidator<DeleteTarefaCommand>
{
    public DeleteTarefaValidator()
    {
        RuleFor(x => x.Name)
            .NotNull()
            .NotEmpty()
            .NotEqual(" ");
    }
}