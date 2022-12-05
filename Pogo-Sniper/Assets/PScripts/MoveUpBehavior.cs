using System.Collections;
using UnityEngine;

public class MoveUpBehavior : MonoBehaviour
{
    public float seconds = 1;
    public WaitForSeconds wfsObj;
    public Transform playerPos;
    private IEnumerator Start()
    {
        playerPos = GameObject.Find("Spawn").transform;
        wfsObj = new WaitForSeconds(seconds);
        yield return wfsObj;
        transform.position = new Vector3(transform.position.x, playerPos.position.y, transform.position.z);
    }

}