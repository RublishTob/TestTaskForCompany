using System;

public class Energy : IEnergyStorage
{
    public event Action OnEnergyChanged;
    private EnergyData _energyData;
    private float _energy;
    private float _maxCapasity;

    public Energy(EnergyData energyData)
    {
        _energyData = energyData;
        _energy = _energyData.Energy;
        _maxCapasity = _energyData.MaxCapacity;
    }
    public float GetEnergyCount { get { return _energy; } }
    public void AddEnergy(float value)
    {
        if (value < 0)
        {
            throw new InvalidOperationException("Value can't be a negative");
        }
        if (_energy >= _maxCapasity)
        {
            return;
        }
        _energy += value;
        OnEnergyChanged?.Invoke();
    }
    public void RemoveEnergy(float value)
    {
        if (value < 0)
        {
            throw new InvalidOperationException("Value can't be a negative");
        }
        if (_energy - value <= 0)
        {
            _energy = 0f;
            return;
        }
        _energy -= value;
        OnEnergyChanged?.Invoke();
    }
}
