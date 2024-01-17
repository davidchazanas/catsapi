using catsapi.Data;

namespace catsapi.Models;

public class Cat : IEntity
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsWonderful { get; set; }
    public string? Achievements { get; set; }
}