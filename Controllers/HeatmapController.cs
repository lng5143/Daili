using Daili.Business.Models;

namespace Daili.Controllers;

[Route("api/[controller]")]
public class HeatmapController : Controllers
{
    private readonly DbContext _dbContext;

    public HeatmapController(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<HeatmapDataDto> GetHeatmapData()
    {
        
    }
}