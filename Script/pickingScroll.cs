using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickingScroll : MonoBehaviour
{
    [SerializeField]
    GameObject Canvas;

    // Use this for initialization
    void Start()
    {
        Canvas.transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
