
using System;

public class GameValueStorage: IGameValueStorage
{
    public event Action OnGemAdded;
    public event Action OnEnergyAdded;

    private IGemStorage _gem;
    private IEnergyStorage _energy;
    private DisposeManager _disposeManager;
    private CalculateValue _calculate;
    private GemData _gemData;
    private EnergyData _energyData;

    public GameValueStorage(IGemStorage gem, IEnergyStorage energy, DisposeManager disposeManager, CalculateValue calculate, GemData gemData, EnergyData energyData)
    {
        _gem = gem;
        _energy = energy;
        _calculate = calculate;
        _gemData = gemData;
        _energyData = energyData;
        _disposeManager = disposeManager;
        _disposeManager.DisposeRes += DisposeRes;
        _gem.OnGemChanged += GemChanged;
        _energy.OnEnergyChanged += EnergyChanged;

    }
    public float GetEnergyCount { get { return _energy.GetEnergyCount; } }
    public int GetGemCount { get { return _gem.GetGemCount; } }

    public void AddGemOnTap()
    {
        if (_energy.GetEnergyCount > 0)
        {
            _gem.AddGem(_calculate.CalculateGems(_gemData.ValueForTap));
            _energy.RemoveEnergy(_energyData.EnergyForTap);
        }
    }
    public void AddGemInTime()
    {
        _gem.AddGem(_gemData.ValueInOneTime);
    }
    public void GemChanged()
    {
        OnGemAdded?.Invoke();
    }
    public void EnergyChanged()
    {
        OnEnergyAdded?.Invoke();
    }
    private void DisposeRes()
    {
        _gem.OnGemChanged -= GemChanged;
        _disposeManager.DisposeRes -= DisposeRes;
    }
}
