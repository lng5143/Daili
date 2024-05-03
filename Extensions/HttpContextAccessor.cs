namespace Daili.Extensions;

public class HttpContextAccessor 
{
    public Guid GetUserId(this HttpContext context) 
    {
        return Guid.Parse(context.User.FindFirstValue(ClaimTypes.NameIdentifier));
    }
}