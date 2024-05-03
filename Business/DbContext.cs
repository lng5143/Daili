namespace Daili.Business;

public class DbContext : DbContext
{
    //public DbSet<HeatmapDataPoint> HeatmapDataPoints { get; set; }
    public DbSet<Task> Tasks {get;set;}
    public DbSet<Category> Categories {get;set;}
    public DbSet<User> Users {get;set;}
    public DbSet<Webhook> Webhooks {get;set;}
    public DbSet<Payment> Payments {get;set;}
}