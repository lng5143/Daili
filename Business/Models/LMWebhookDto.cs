using System.Text.Json.Serialization;

namespace Daili.Business.Models;

public class LMWebhookDto
{
    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }

    [JsonPropertyName("data")]
    public Data Data { get; set; }
}

public class Meta
{
    [JsonPropertyName("event_name")]
    public string EventName { get; set; }
}

public class Data
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("attributes")]
    public Attributes Attributes { get; set; }

    [JsonPropertyName("relationships")]
    public Relationships Relationships { get; set; }

    [JsonPropertyName("links")]
    public Links Links { get; set; }
}

public class Attributes
{
    [JsonPropertyName("store_id")]
    public int StoreId { get; set; }

    [JsonPropertyName("customer_id")]
    public int CustomerId { get; set; }

    [JsonPropertyName("order_id")]
    public int OrderId { get; set; }

    [JsonPropertyName("order_item_id")]
    public int OrderItemId { get; set; }

    [JsonPropertyName("product_id")]
    public int ProductId { get; set; }

    [JsonPropertyName("variant_id")]
    public int VariantId { get; set; }

    [JsonPropertyName("product_name")]
    public string ProductName { get; set; }

    [JsonPropertyName("variant_name")]
    public string VariantName { get; set; }

    [JsonPropertyName("user_name")]
    public string UserName { get; set; }

    [JsonPropertyName("user_email")]
    public string UserEmail { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("status_formatted")]
    public string StatusFormatted { get; set; }

    [JsonPropertyName("card_brand")]
    public string CardBrand { get; set; }

    [JsonPropertyName("card_last_four")]
    public string CardLastFour { get; set; }

    [JsonPropertyName("pause")]
    public object Pause { get; set; }

    [JsonPropertyName("cancelled")]
    public bool Cancelled { get; set; }

    [JsonPropertyName("trial_ends_at")]
    public string TrialEndsAt { get; set; }

    [JsonPropertyName("billing_anchor")]
    public int BillingAnchor { get; set; }

    [JsonPropertyName("first_subscription_item")]
    public FirstSubscriptionItem FirstSubscriptionItem { get; set; }

    [JsonPropertyName("urls")]
    public Urls Urls { get; set; }

    [JsonPropertyName("renews_at")]
    public string RenewsAt { get; set; }

    [JsonPropertyName("ends_at")]
    public object EndsAt { get; set; }

    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public string UpdatedAt { get; set; }

    [JsonPropertyName("test_mode")]
    public bool TestMode { get; set; }
}

public class FirstSubscriptionItem
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("subscription_id")]
    public int SubscriptionId { get; set; }

    [JsonPropertyName("price_id")]
    public int PriceId { get; set; }

    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public string UpdatedAt { get; set; }
}

public class Urls
{
    [JsonPropertyName("update_payment_method")]
    public string UpdatePaymentMethod { get; set; }

    [JsonPropertyName("customer_portal")]
    public string CustomerPortal { get; set; }
}

public class Relationships
{
    [JsonPropertyName("store")]
    public Store Store { get; set; }

    [JsonPropertyName("customer")]
    public Customer Customer { get; set; }

    [JsonPropertyName("order")]
    public Order Order { get; set; }

    [JsonPropertyName("order-item")]
    public OrderItem OrderItem { get; set; }

    [JsonPropertyName("product")]
    public Product Product { get; set; }

    [JsonPropertyName("variant")]
    public Variant Variant { get; set; }

    [JsonPropertyName("subscription-items")]
    public SubscriptionItems SubscriptionItems { get; set; }

    [JsonPropertyName("subscription-invoices")]
    public SubscriptionInvoices SubscriptionInvoices { get; set; }
}

public class Store
{
    [JsonPropertyName("links")]
    public Links Links { get; set; }
}

public class Customer
{
    [JsonPropertyName("links")]
    public Links Links { get; set; }
}

public class Order
{
    [JsonPropertyName("links")]
    public Links Links { get; set; }
}

public class OrderItem
{
    [JsonPropertyName("links")]
    public Links Links { get; set; }
}

public class Product
{
    [JsonPropertyName("links")]
    public Links Links { get; set; }
}

public class Variant
{
    [JsonPropertyName("links")]
    public Links Links { get; set; }
}

public class SubscriptionItems
{
    [JsonPropertyName("links")]
    public Links Links { get; set; }
}

public class SubscriptionInvoices
{
    [JsonPropertyName("links")]
    public Links Links { get; set; }
}

public class Links
{
    [JsonPropertyName("related")]
    public string Related { get; set; }

    [JsonPropertyName("self")]
    public string Self { get; set; }
}
