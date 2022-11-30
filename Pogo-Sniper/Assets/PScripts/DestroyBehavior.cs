using System.Collections;
using UnityEngine;

public class DestroyBehavior : MonoBehaviour
{
    public float seconds = 1;
    public WaitForSeconds wfsObj;
   
    private IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        yield return wfsObj;
        Destroy(gameObject);
    }
    void OnCollisionEnter (Collider target) 
    {
        if( target.gameObject.tag.Equals("Target") == true )
        {
            Destroy(gameObject);
        }
    }
 
 
}
