
public class TimerPresener: IPresenter
{
    private TimerView _gemView;
    private IGameValueStorage _gameValueStorage;
    public TimerPresener(TimerView view, IGameValueStorage model)
    {
        _gemView = view;
        _gameValueStorage = model;
    }
    public void Show()
    {
        _gemView.OnValueTap += UpdateValueGem;
    }
    public void Hide()
    {
        _gemView.OnValueTap -= UpdateValueGem;
    }
    public void UpdateValueGem()
    {
        _gameValueStorage.AddGemInTime();
    }
    public void SetTimerRun()
    {
        _gemView.SetTimeRun(true);
    }
    public void SetTimerStop()
    {
        _gemView.SetTimeRun(false);
    }
}
