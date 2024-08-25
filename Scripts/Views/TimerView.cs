using System;
using UnityEngine;

public class TimerView : MonoBehaviour
{
    private float _time;
    private float _limitTimeToTap = 5f;
    private bool _isRunning;

    public Action OnValueTap;

    private void Start()
    {
        _time = _limitTimeToTap;
    }
    void Update()
    {
        if (_isRunning)
        TimeRun();
    }
    private void TimeRun()
    {
        _time -= Time.deltaTime;
        Debug.Log($"{_time}");
        if (_time <= 0)
        {
            _time = _limitTimeToTap;
            OnValueTap?.Invoke();
        }
    }
    public void SetLimitTime(float limit)
    {
        _limitTimeToTap = limit;
    }
    public void SetTimeRun(bool isRun)
    {
        _isRunning = isRun;
    }
}
