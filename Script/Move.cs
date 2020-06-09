using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    GameObject cam;
    [SerializeField]
    ModelButton mb;
    [SerializeField]
    GameObject house;

    public int MoveCount = 0;

    Vector3 pos = new Vector3(-26, 36, -43);
    Quaternion roPos = Quaternion.Euler(new Vector3(25, 35, 0));

    // Start is called before the first frame update
    void Start()
    {
        house = GameObject.Find("House");
    }
    void FixedUpdate()
    {
        MoveCount = mb.count;
        if(MoveCount == 0)
        {
            transform.position = Vector3.Lerp(transform.position, pos, 2 * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, roPos, 2 * Time.deltaTime);
        }
        
    }
    // Update is called once per frame
    void Update()
    {

    }
}
