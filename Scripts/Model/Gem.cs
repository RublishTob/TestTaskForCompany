using System;

public class Gem : IGemStorage
{
    public event Action OnGemChanged;
    private GemData _gemData;

    private int _maxCapasity;
    private int _gem;

    public Gem(GemData gemData)
    {
        _gemData = gemData;
        _gem = _gemData.Gems;
        _maxCapasity = _gemData.MaxCapacity;
    }
    public int GetGemCount { get { return _gem; } }
    public void AddGem(int value)
    {
        if (value < 0)
        {
            throw new InvalidOperationException("Value can't be a negative");
        }
        if (_gem + value >= _maxCapasity)
        {
            _gem = _maxCapasity;
            OnGemChanged?.Invoke();
            return;
        }
        _gem += value;
        OnGemChanged?.Invoke();
    }

    public void RemoveGem(int value)
    {
        if (value < 0)
        {
            throw new InvalidOperationException("Value can't be a negative");
        }
        if (_gem - value <= 0)
        {
            _gem = 0;
            return;
        }
        _gem -= value;
        OnGemChanged?.Invoke();
    }
}
