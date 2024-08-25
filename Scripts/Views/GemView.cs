using TMPro;
using UnityEngine;

public class GemView : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    public void SetGem(string gemValue)
    {
        _text.text = gemValue;
    }
}
