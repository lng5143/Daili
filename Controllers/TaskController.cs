namespace Daili.Controllers;

public class TaskController : Controllers
{
    private readonly ITaskService _taskService;


    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    public Task GetAll()
    {
        return _dbContext.Tasks.ToListAsync();
    }

    public 
}