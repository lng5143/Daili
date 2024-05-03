namespace Daili.Business.Models;

public class HeatmapDataDto
{
    public List<HeatmapDataPointDto> DataPoints { get; set; }
}

public class HeatmapDataPointDto
{
    public DateTime Date {get;set;}
    public int Value { get; set; }
}

