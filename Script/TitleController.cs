using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleController : MonoBehaviour
{
    [SerializeField]
    GameObject bg;
    [SerializeField]
    GameObject title;

    public void SetTitle()
    {
        bg.SetActive(false);
        title.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        title.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
