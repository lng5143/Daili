namespace Daili.Business.Entities;

public class BaseEntity
{
    public Guid Id {get;set;}
    public DateTime CreatedTime {get;set;}
    public DateTime LastEdited {get;set;}
    public bool IsDeleted {get;set;}

    public BaseEntity()
    {
        Id = Guid.NewGuid();
        CreatedTime = DateTime.Now;
        LastEdited = DateTime.Now;
        IsDeleted = false;
    }
}