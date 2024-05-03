using Daili.Business.Entities;

namespace Daili.Controllers;

[Route("api/[controller]")]
public class PaymentController : Controllers
{
    private readonly DbContext _dbContext;
    private readonly HttpContextAccessor _httpContextAccessor;
    private readonly ILemonSqueezyService _lemonSqueezyService; 
    public PaymentController(
        DbContext dbContext,
        HttpContextAccessor httpContextAccessor,
        ILemonSqueezyService lemonSqueezyService)
    {
        _dbContext = dbContext;
        _httpContextAccessor = httpContextAccessor;
        _lemonSqueezyService = lemonSqueezyService;
    }

    public Task CreateLMCheckout()
    {

    }

    [HttpPost]
    [Route("lm-webhook")]
    public Task HandleLMWebhook([FromBody] LMWebhookDto webhook)
    {
        var webhook = new Webhook()
        {
            UserId = _httpContextAccessor.GetUserId(),
            JsonData = JsonSerializer.Serialize(webhook),
            Status = WebhookStatus.Pending
        }

        _dbContext.Webhooks.Add(webhook);


    }
}