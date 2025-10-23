using FluentValidation;

namespace Application.UseCases.Commands.Create;

public class CreateTarefaValidator : AbstractValidator<CreateTarefaCommand>
{
    public CreateTarefaValidator()
    {
        RuleFor(x => x.Name)
            .NotNull()
            .NotEmpty()
            .NotEqual(" ")
            .Must(x => x.Length >= 3) // O atributo X tem que obedecer essa lógica
            .WithMessage("O nome é muito curto."); 
        
        RuleFor(x => x.Description)
            .NotEmpty()
            .NotEqual(" ");
    }
}