using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu]
public class IntDataP : ScriptableObject
{
    public int value;
    
    public void SetValue(int num)
    {
        value = num;
    }

    public void CompareValue(IntDataP obj)
    {
        if (value >= obj.value)
        {
            
        }
        else
        {
            value = obj.value;
        }

    }

    public void SetValue(IntDataP obj)
    {
        value = obj.value;
    }

    public void UpdateValue(int num)
    {
        value += num;
    }

    
}