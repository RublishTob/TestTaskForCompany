using UnityEngine;

[CreateAssetMenu(fileName = "Gem", menuName = "PlayerValueGem")]
public class GemData : ScriptableObject
{
    [field: SerializeField] public int Gems { get; private set; }
    [field: SerializeField] public int ValueForTap { get; private set; }
    [field: SerializeField] public int ModifierTap { get; private set; }
    [field: SerializeField] public int ValueInOneTime { get; private set; }
    [field: SerializeField] public int SubstractValueInOneTime { get; private set; }
    [field: SerializeField] public int MaxCapacity { get; private set; }
}

