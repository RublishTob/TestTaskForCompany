using UnityEngine;
using Zenject;

public class GameplayInstaller : MonoInstaller
{
    [SerializeField] private ButtonView _button;
    [SerializeField] private GemView _gem;
    [SerializeField] private TimerView _timerView;
    [SerializeField] private EnergyView _energy;
    [SerializeField] private GemData _gemData;
    [SerializeField] private EnergyData _energyData;
    [SerializeField] private GameStateWatcher _gameStateWatcher;
    [SerializeField] private SpawnGem _spawnGem;
    public override void InstallBindings()
    {
        BindData();
        BindModels();
        BindViews();
        BindPresenters();

        Container.Bind<GameStateWatcher>().FromInstance(_gameStateWatcher).AsSingle();
    }
    private void BindPresenters()
    {
        Container.BindInterfacesAndSelfTo<TimerPresener>().AsSingle().NonLazy();
        Container.BindInterfacesAndSelfTo<GemPresenter>().AsSingle().NonLazy();
        Container.BindInterfacesAndSelfTo<EnergyPresenter>().AsSingle().NonLazy();
        Container.BindInterfacesAndSelfTo<ButtonTapPresenter>().AsSingle().NonLazy();
    }
    private void BindData()
    {
        Container.Bind<GemData>().FromInstance(_gemData).AsSingle();
        Container.Bind<EnergyData>().FromInstance(_energyData).AsSingle();
    }
    private void BindModels()
    {
        Container.BindInterfacesAndSelfTo<Energy>().AsSingle();
        Container.BindInterfacesAndSelfTo<Gem>().AsSingle();
        Container.Bind<CalculateValue>().AsSingle();
        Container.BindInterfacesAndSelfTo<GameValueStorage>().AsSingle();
    }
    private void BindViews()
    {
        Container.Bind<ButtonView>().FromInstance(_button).AsSingle();
        Container.Bind<SpawnGem>().FromInstance(_spawnGem).AsSingle();
        Container.Bind<GemView>().FromInstance(_gem).AsSingle();
        Container.Bind<EnergyView>().FromInstance(_energy).AsSingle();
        Container.Bind<TimerView>().FromInstance(_timerView).AsSingle();
    }
}
