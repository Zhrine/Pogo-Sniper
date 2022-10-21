using UnityEngine;
[CreateAssetMenu]
public class Vector3Data : MonoBehaviour
{
    public Vector3 value;
    public Vector3 position;

    public void SetValue(Vector3 v3)
    {
        value = v3;
    }

}
