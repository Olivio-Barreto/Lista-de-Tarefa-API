namespace Core.Domain;

public class Tarefa : BaseEntity
{
    public string Name { get; private set; } = null!;
    public string? Description { get; private set; }
    public bool IsCompleted { get; private set; }
    private string _errorMessage = null!;
    public Tarefa()
    {
        Id = Guid.NewGuid();
    }

    public Tarefa(string name, string description) : this()
    {
        Name = name;
        Description = description;
    }

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(name))
        {
            _errorMessage = "O Nome não pode ser nulo.";
            throw new ArgumentNullException(nameof(name), _errorMessage);
        }

        if (name.Length < 3)
        {
            _errorMessage = "Nome muito curto.";
            throw new ArgumentOutOfRangeException(nameof(name), _errorMessage);
        }
        Name = name;
    }

    public void SetDescription(string description)
    {
        if (string.IsNullOrWhiteSpace(description) || string.IsNullOrEmpty(description))
        {
            _errorMessage = "A descrição não pode ser nula.";
            throw new ArgumentNullException(nameof(description), _errorMessage);
        }

        Description = description;
    }
    
    public void Complete() => IsCompleted = true;
}