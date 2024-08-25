
using System;

public interface IEnergyStorage
{
    public event Action OnEnergyChanged;
    public void AddEnergy(float value);
    public void RemoveEnergy(float value);
    public float GetEnergyCount { get; }
}
