using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Button _button;

    public Action OnButtonClicked;

    public void Click()
    {
        OnButtonClicked?.Invoke();
    }
    private void OnEnable()
    {
        _button.onClick.AddListener(Click);
    }
    private void OnDisable()
    {
        _button.onClick.RemoveListener(Click);
    }


}
