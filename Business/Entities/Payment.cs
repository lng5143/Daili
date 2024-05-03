using Daili.Business.Enums;

namespace Daili.Business.Entities;

public class Payment 
{
    public Guid UserId {get;set;}
    public PaymentStatus Status {get;set;}
    
}