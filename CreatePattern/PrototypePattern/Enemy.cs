using PrototypePattern.Entities;

namespace PrototypePattern;

public abstract class Enemy
{
    public string? Name { get; set; }
    public string? Color { get; set; }
    public Gun? Gun { get; set; }
}