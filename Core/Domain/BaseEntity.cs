namespace Core.Domain;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateOnly DateCreated { get; set; }
    public DateOnly DateModified { get; set; }
    public DateOnly  DateDeleted { get; set; }
}