
using System;

public interface IGemStorage
{
    public event Action OnGemChanged;
    public void AddGem(int value);
    public void RemoveGem(int value);
    public int GetGemCount { get; }
}
