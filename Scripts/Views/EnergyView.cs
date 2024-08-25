using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class EnergyView : MonoBehaviour
{
    [SerializeField] private Slider _energy;

    public void SetEnergy(float energy)
    {
        _energy.value = energy;
    }
}
