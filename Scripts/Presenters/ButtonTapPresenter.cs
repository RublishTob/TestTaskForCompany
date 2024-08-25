
public class ButtonTapPresenter : IPresenter
{
    private ButtonView _buttonView;
    private IGameValueStorage _gameValueStorage;
    private SpawnGem _spawner;
    public ButtonTapPresenter(ButtonView view, IGameValueStorage model, SpawnGem spawner)
    {
        _buttonView = view;
        _gameValueStorage = model;
        _spawner = spawner;
    }
    public void Show()
    {
        _buttonView.OnButtonClicked += Click;
        _gameValueStorage.OnGemAdded += SpawnGem;
    }
    public void Hide()
    {
        _gameValueStorage.OnGemAdded -= SpawnGem;
        _buttonView.OnButtonClicked -= Click;
    }
    private void Click()
    {
        _gameValueStorage.AddGemOnTap();
    }
    private void SpawnGem()
    {
        _spawner.Spawn();
    }
}
