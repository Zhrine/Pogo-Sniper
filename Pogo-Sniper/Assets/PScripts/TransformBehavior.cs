using System.Collections;
using UnityEngine;

public class TransformBehavior : MonoBehaviour
{
    public Vector3Data v3Data;
    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    public BoolData canRun;

    public void ResetToZero()
    {
        transform.position = Vector3.zero;
    }

    public void SetV3Value()
    {
        v3Data.value = transform.position;
    }
    
    // have to have a unity event to start this.
    public void StartRunsetValue()
    {
        canRun.value = true;
        StartCoroutine(RunSetValue());
    }

    private IEnumerator RunSetValue()
    {
        while (canRun.value)
        {
            SetV3Value();
            yield return wffu;
        }
    }
}
