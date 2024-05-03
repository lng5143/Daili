using System.Text.Json;

namespace Daili.Business.Models;
public class LMCreateCheckoutResponse
{
    [JsonProperty("jsonapi")]
    public JsonApi JsonApi { get; set; }

    [JsonProperty("links")]
    public Links Links { get; set; }

    [JsonProperty("data")]
    public Data Data { get; set; }

    [JsonProperty("relationships")]
    public Relationships Relationships { get; set; }
}

public class JsonApi
{
    [JsonProperty("version")]
    public string Version { get; set; }
}

public class Links
{
    [JsonProperty("self")]
    public string Self { get; set; }
}

public class Data
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("attributes")]
    public Attributes Attributes { get; set; }

    [JsonProperty("links")]
    public Links Links { get; set; }
}

public class Attributes
{
    [JsonProperty("store_id")]
    public int StoreId { get; set; }

    [JsonProperty("variant_id")]
    public int VariantId { get; set; }

    [JsonProperty("custom_price")]
    public int CustomPrice { get; set; }

    [JsonProperty("product_options")]
    public ProductOptions ProductOptions { get; set; }

    [JsonProperty("checkout_options")]
    public CheckoutOptions CheckoutOptions { get; set; }

    [JsonProperty("checkout_data")]
    public CheckoutData CheckoutData { get; set; }

    [JsonProperty("preview")]
    public Preview Preview { get; set; }

    [JsonProperty("expires_at")]
    public string ExpiresAt { get; set; }

    [JsonProperty("created_at")]
    public string CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public string UpdatedAt { get; set; }

    [JsonProperty("test_mode")]
    public bool TestMode { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}

public class ProductOptions
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("media")]
    public string[] Media { get; set; }

    [JsonProperty("redirect_url")]
    public string RedirectUrl { get; set; }

    [JsonProperty("receipt_button_text")]
    public string ReceiptButtonText { get; set; }

    [JsonProperty("receipt_link_url")]
    public string ReceiptLinkUrl { get; set; }

    [JsonProperty("receipt_thank_you_note")]
    public string ReceiptThankYouNote { get; set; }

    [JsonProperty("enabled_variants")]
    public int[] EnabledVariants { get; set; }
}

public class CheckoutOptions
{
    [JsonProperty("embed")]
    public bool Embed { get; set; }

    [JsonProperty("media")]
    public bool Media { get; set; }

    [JsonProperty("logo")]
    public bool Logo { get; set; }

    [JsonProperty("desc")]
    public bool Desc { get; set; }

    [JsonProperty("discount")]
    public bool Discount { get; set; }

    [JsonProperty("skip_trial")]
    public bool SkipTrial { get; set; }

    [JsonProperty("dark")]
    public bool Dark { get; set; }

    [JsonProperty("subscription_preview")]
    public bool SubscriptionPreview { get; set; }

    [JsonProperty("button_color")]
    public string ButtonColor { get; set; }
}

public class CheckoutData
{
    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("billing_address")]
    public string[] BillingAddress { get; set; }

    [JsonProperty("tax_number")]
    public string TaxNumber { get; set; }

    [JsonProperty("discount_code")]
    public string DiscountCode { get; set; }

    [JsonProperty("custom")]
    public string[] Custom { get; set; }

    [JsonProperty("variant_quantities")]
    public int[] VariantQuantities { get; set; }
}

public class Preview
{
    [JsonProperty("currency")]
    public string Currency { get; set; }

    [JsonProperty("currency_rate")]
    public int CurrencyRate { get; set; }

    [JsonProperty("subtotal")]
    public int Subtotal { get; set; }

    [JsonProperty("discount_total")]
    public int DiscountTotal { get; set; }

    [JsonProperty("tax")]
    public int Tax { get; set; }

    [JsonProperty("total")]
    public int Total { get; set; }

    [JsonProperty("subtotal_usd")]
    public int SubtotalUsd { get; set; }

    [JsonProperty("discount_total_usd")]
    public int DiscountTotalUsd { get; set; }

    [JsonProperty("tax_usd")]
    public int TaxUsd { get; set; }

    [JsonProperty("total_usd")]
    public int TotalUsd { get; set; }

    [JsonProperty("subtotal_formatted")]
    public string SubtotalFormatted { get; set; }

    [JsonProperty("discount_total_formatted")]
    public string DiscountTotalFormatted { get; set; }

    [JsonProperty("tax_formatted")]
    public string TaxFormatted { get; set; }

    [JsonProperty("total_formatted")]
    public string TotalFormatted { get; set; }
}

public class Relationships
{
    [JsonProperty("store")]
    public Store Store { get; set; }

    [JsonProperty("variant")]
    public Variant Variant { get; set; }
}

public class Store
{
    [JsonProperty("links")]
    public Links Links { get; set; }
}

public class Variant
{
    [JsonProperty("links")]
    public Links Links { get; set; }
}
