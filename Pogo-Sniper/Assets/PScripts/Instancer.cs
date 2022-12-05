using System;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    public GameObject cameraPos;
    private int num;
    


    public void CreateInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        foreach (var t in obj.vector3List)
        {
            Instantiate(prefab, t.value, Quaternion.identity);
        }
    }

    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);
        num++;
        if (num == obj.vector3List.Count)
        {
            num = 0;
        }
    }

    public void CreateInstanceFromListRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3List.Count - 1);
        Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);


    }


}
/*
 //using System.Collections;

using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {

    private CharacterController _controller;

    public PlayerPosition playerPosition;

    // Use this for initialization
    void Start () {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update () {

        Vector3 next = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if (next != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(next);
        _controller.Move(next / 8);

        playerPosition.position = transform.position;
        playerPosition.rotation = transform.rotation;
    }
}*/


