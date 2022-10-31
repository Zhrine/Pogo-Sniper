using UnityEngine;
using System.Collections;
  
public class FollowX : MonoBehaviour
{
  
    public Transform bar;
  
    void Start() 
    {
        bar = GameObject.Find("Target").transform;
    }
  
    void Update() 
    {
        transform.position = new Vector3(bar.position.x, transform.position.y, transform.position.z);
    }
}