using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ardunity;

public class windowMove : MonoBehaviour
{
    [SerializeField]
    AnalogInput al;
    [SerializeField]
    GenericServo servo;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        servo.angle = -al.Value * 100;
    }
}
