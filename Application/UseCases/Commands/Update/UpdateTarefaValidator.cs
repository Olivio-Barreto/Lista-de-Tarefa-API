using FluentValidation;

namespace Application.UseCases.Commands.Update;

public sealed class UpdateTarefaValidator : AbstractValidator<UpdateTarefaCommand>
{
    public UpdateTarefaValidator()
    {
        RuleFor(x => x.Id).NotNull().NotEmpty();
        RuleFor(x =>  x.Name)
            .Must(x => x is { Length: >= 3 })
            .When(x => x.Name != null);
    }
}