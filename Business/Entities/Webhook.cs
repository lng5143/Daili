namespace Daili.Business.Entities;

public class Webhook : BaseEntity
{
    public string JsonData {get;set;}
    public WebhookStatus Status {get;set;}
    public Guid UserId {get;set;}
}