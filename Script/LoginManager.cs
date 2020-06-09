using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    [SerializeField]
    GameObject Connect;
    [SerializeField]
    GameObject Disconnect;
    [SerializeField]
    GameObject Login;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Connect.activeSelf==true && Disconnect.activeSelf == false)
        {
            Login.GetComponent<Button>().enabled = false;
        }
        if (Connect.activeSelf == false && Disconnect.activeSelf == true)
        {
            Login.GetComponent<Button>().enabled = true;
            Login.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }
    }
}
