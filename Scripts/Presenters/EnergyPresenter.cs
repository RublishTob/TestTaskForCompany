
public class EnergyPresenter : IPresenter
{
    private EnergyView _energyView;
    private IGameValueStorage _gameValueStorage;
    public EnergyPresenter(EnergyView view, IGameValueStorage model)
    {
        _energyView = view;
        _gameValueStorage = model;
        UpdateEnergy();
    }
    public void Show()
    {
        _gameValueStorage.OnEnergyAdded += UpdateEnergy;
    }
    public void Hide()
    {
        _gameValueStorage.OnEnergyAdded -= UpdateEnergy;
    }
    public void UpdateEnergy()
    {
        float value = _gameValueStorage.GetEnergyCount;
        _energyView.SetEnergy(value / 100);
    }
}
