using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Ardunity;

public class moveDetect : MonoBehaviour
{
    [SerializeField]
    GameObject bm;
    [SerializeField]
    GameObject lighton;
    [SerializeField]
    GameObject lightoff;

    public float dist;
    public int moveDetectCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //bm = GameObject.Find("ButtonManager_Title");
    }

    // Update is called once per frame
    void Update()
    {
        bm = GameObject.Find("ButtonManager_Title");
        //Debug.Log("bm.modecount: " + bm.GetComponent<ButtonManager>().modeCount);
        if (bm.GetComponent<ButtonManager>().modeCount == 0)
        {
            dist = gameObject.GetComponent<HCSR04>().distance;
            if (dist > 50f || dist < 5f)
            {
                moveDetectCount = 1;
            }
            else
            {
                moveDetectCount = 0;
            }
        }

    }
}
