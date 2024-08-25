
using System;

public interface IGameValueStorage
{
    public event Action OnGemAdded;
    public event Action OnEnergyAdded;
    public float GetEnergyCount { get; }
    public int GetGemCount { get; }
    public void AddGemOnTap();
    public void AddGemInTime();
}
