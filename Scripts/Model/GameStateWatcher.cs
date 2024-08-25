using System;
using UnityEngine;
using Zenject;

public class GameStateWatcher : MonoBehaviour
{
    private DisposeManager _disposeManager;
    private IPresenter[] _presenters;
    private TimerPresener _timer;

    [Inject]
    public void Construct(DisposeManager disposeManager, IPresenter[] presenters, TimerPresener timer)
    {
        _disposeManager = disposeManager;
        _presenters = presenters;
        _timer = timer;
    }

    public void StartGame()
    {
        foreach (var presenter in _presenters)
        {
            presenter.Show();
        }
        _timer.SetTimerRun();
    }
    public void StopGame()
    {
        foreach (var presenter in _presenters)
        {
            presenter.Hide();
        }
        _timer.SetTimerStop();
        _disposeManager.DisposeResourses();
    }
}
