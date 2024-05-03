namespace Daily.Services;

public class ITaskService
{
    Task GetAll();
    Task CreateOrEdit();
    Task Delete();
}

public class TaskService : ITaskService
{
    private readonly DbContext _dbContext;

    public TaskService(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task GetAll()
    {
        return _dbContext.Tasks.ToListAsync();
    }

    public Task CreateOrEdit()
}