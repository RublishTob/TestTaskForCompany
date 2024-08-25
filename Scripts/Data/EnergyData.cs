using UnityEngine;

[CreateAssetMenu(fileName = "Energy", menuName ="PlayerValueEnergy")]
public class EnergyData : ScriptableObject
{
    [field:SerializeField] public float Energy {  get; private set; }
    [field: SerializeField] public float MaxCapacity { get; private set; }
    [field: SerializeField] public float EnergyForTap { get; private set; }
}
