using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ardunity;

public class windowbehavior : MonoBehaviour
{
    [SerializeField]
    GameObject obj;
    [SerializeField]
    GenericServo gs;
    [SerializeField]
    GameObject house;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //obj.transform.rotation = Quaternion.Euler(gs.angle, 0, 0);
        obj.transform.Rotate(gs.angle, 0, 0);
    }
}
