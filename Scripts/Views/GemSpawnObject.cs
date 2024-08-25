using DG.Tweening;
using UnityEngine;

public class GemSpawnObject : MonoBehaviour
{
    [SerializeField] private Transform endPosition;

    private Sequence sequense;
    void Start()
    {
        sequense = DOTween.Sequence();
        sequense.Append(transform.DOMove(endPosition.position, 1f));
        sequense.AppendCallback(() => DestroyObject());
    }
    private void DestroyObject()
    {
        Destroy(gameObject);
    }
}
