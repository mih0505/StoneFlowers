namespace Domain.Interfaces;

public interface IBaseModel
{
    public Guid Id { get; set; }
            
    public bool IsDeleted { get; set; }
}