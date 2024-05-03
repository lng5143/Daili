using System.Text.Json.Serialization;

public class LMCreateCheckoutRequest
{
    [JsonPropertyName("data")]
    public Data Data { get; set; }
}

public class Data
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("attributes")]
    public Attributes Attributes { get; set; }

    [JsonPropertyName("relationships")]
    public Relationships Relationships { get; set; }
}

public class Attributes
{
    [JsonPropertyName("custom_price")]
    public int CustomPrice { get; set; }

    [JsonPropertyName("product_options")]
    public ProductOptions ProductOptions { get; set; }

    [JsonPropertyName("checkout_options")]
    public CheckoutOptions CheckoutOptions { get; set; }

    [JsonPropertyName("checkout_data")]
    public CheckoutData CheckoutData { get; set; }

    [JsonPropertyName("expires_at")]
    public string ExpiresAt { get; set; }

    [JsonPropertyName("preview")]
    public bool Preview { get; set; }
}

public class ProductOptions
{
    [JsonPropertyName("enabled_variants")]
    public int[] EnabledVariants { get; set; }
}

public class CheckoutOptions
{
    [JsonPropertyName("button_color")]
    public string ButtonColor { get; set; }
}

public class CheckoutData
{
    [JsonPropertyName("discount_code")]
    public string DiscountCode { get; set; }

    [JsonPropertyName("custom")]
    public Custom Custom { get; set; }
}

public class Custom
{
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
}

public class Relationships
{
    [JsonPropertyName("store")]
    public Store Store { get; set; }

    [JsonPropertyName("variant")]
    public Variant Variant { get; set; }
}

public class Store
{
    [JsonPropertyName("data")]
    public StoreData Data { get; set; }
}

public class StoreData
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

public class Variant
{
    [JsonPropertyName("data")]
    public VariantData Data { get; set; }
}

public class VariantData
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}