using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var downSpeed = Time.deltaTime*2;
        transform.position = new Vector3(transform.position.x,
            transform.position.y - downSpeed,
            transform.position.z);
    }
}
