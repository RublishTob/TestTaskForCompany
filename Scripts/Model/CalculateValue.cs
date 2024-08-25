
using UnityEngine;

public class CalculateValue
{
   private GemData _gemData;
   private int _modifier;
   private int _addOnValueInTime = 0;

   private float ValueInTime;
   private float SubstractValueInOneTime;

    public CalculateValue(GemData gemData)
    {
        _gemData = gemData;
        _modifier = _gemData.ModifierTap;
        ValueInTime = _gemData.ValueInOneTime;
        SubstractValueInOneTime = _gemData.SubstractValueInOneTime;

        _addOnValueInTime += (int)((ValueInTime / 100) * SubstractValueInOneTime);
    }

    public int CalculateGems(int gems)
   {
        return (gems * _modifier) + _addOnValueInTime;
   }
}
