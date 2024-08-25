using UnityEngine;

public class SpawnGem : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _gem;

    public void Spawn()
    {
        Instantiate(_gem, _spawnPoint);
    }
}
