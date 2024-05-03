namespace Daili.Services;

public interface ILemonSqueezyService
{
    Task CreateCheckoutAsync();
    Task CancelSubscription();
    Task<bool> VerifyWebhookSignature(string signature, string payload);
}

public class LemonSqueezyService : ILemonSqueezyService
{
    public LemonSqueezyService()
    {

    }

    public Task CreateCheckoutAsync()
    {
        var httpClient = new HttpClient();

    }

    public Task CancelSubscription()
    {

    }

    public Task<bool> VerifyWebhookSignature(string signature, string payload)
    {
        var secretKey = "";
        using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secretKey));
        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(payload));
        var hashString = BitConverter.ToString(hash).Replace("-", "").ToLower();
        return hashString.Equals(signature);
    }
}