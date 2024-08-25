
public class GemPresenter : IPresenter
{
    private GemView _gemView;
    private IGameValueStorage _gameValueStorage;
    public GemPresenter(GemView view, IGameValueStorage model)
    {
        _gemView = view;
        _gameValueStorage = model;
        UpdateGem();
    }
    public void Show()
    {
        _gameValueStorage.OnGemAdded += UpdateGem;
    }
    public void Hide()
    {
        _gameValueStorage.OnGemAdded -= UpdateGem;
    }
    public void UpdateGem()
    {
        int value = _gameValueStorage.GetGemCount;
        _gemView.SetGem(value.ToString());
    }
}
