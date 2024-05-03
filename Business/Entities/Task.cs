namespace Daili.Business.Entities;

public class Task : BaseEntity
{
    public string Name {get;set;}
    public string Description {get;set;}
    public TaskStatus Status {get;set;}
    public DateTime DueDate {get;set;}
    public Guid UserId {get;set;}
}