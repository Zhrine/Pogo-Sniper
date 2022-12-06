using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
        
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj == null)
            yield break;
        
        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            
            matchEvent.Invoke();
            print("match");
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(4.0f);
            noMatchDelayedEvent.Invoke();

        }
    }
    
    

}
