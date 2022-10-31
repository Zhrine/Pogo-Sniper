using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIDlist;

    public ColorID currentColor;

    private int num;

    public void SetCurrentColorRandomly()
    {
        num = Random.Range(0, colorIDlist.Count);
        currentColor = colorIDlist[num];
        Debug.Log(num);
    }
}
