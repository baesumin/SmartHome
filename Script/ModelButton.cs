using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelButton : MonoBehaviour
{
    [SerializeField]
    GameObject cam;
    [SerializeField]
    GameObject house;

    public int count = 0;

    Vector3 bedpos = new Vector3(2, 10, -25);
    Quaternion bedroPos = Quaternion.Euler(new Vector3(32, 2, 1));
    Vector3 smallpos = new Vector3(-20, 11, 0);
    Quaternion smallroPos = Quaternion.Euler(new Vector3(19, 41, -3));
    Vector3 bathpos = new Vector3(-18, 10, -24);
    Quaternion bathroPos = Quaternion.Euler(new Vector3(25, 35, 0));
    
    public void Bedroom()
    {
        count = 1;
        house.transform.position = Vector3.zero;
        house.transform.rotation = Quaternion.Euler(Vector3.zero);
        house.transform.localScale = Vector3.one;
    }
    public void Smallroom()
    {
        count = 2;
        house.transform.position = Vector3.zero;
        house.transform.rotation = Quaternion.Euler(Vector3.zero);
        house.transform.localScale = Vector3.one;
    }
    public void Bathroom()
    {
        count = 3;
        house.transform.position = Vector3.zero;
        house.transform.rotation = Quaternion.Euler(Vector3.zero);
        house.transform.localScale = Vector3.one;
    }
    // Start is called before the first frame update
    void Start()
    {
        house = GameObject.Find("House");   
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 1)
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, bedpos, 2 * Time.deltaTime);
            cam.transform.rotation = Quaternion.Lerp(cam.transform.rotation, bedroPos, 2 * Time.deltaTime);
        }
        if (count == 2)
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, smallpos, 2 * Time.deltaTime);
            cam.transform.rotation = Quaternion.Lerp(cam.transform.rotation, smallroPos, 2 * Time.deltaTime);
        }
        if (count == 3)
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, bathpos, 2 * Time.deltaTime);
            cam.transform.rotation = Quaternion.Lerp(cam.transform.rotation, bathroPos, 2 * Time.deltaTime);
        }
    }
}
