using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    GameObject CirGreen;
    [SerializeField]
    GameObject CirYellow;
    [SerializeField]
    GameObject lightIcon;
    [SerializeField]
    GameObject md;
    [SerializeField]
    GameObject PopupOK_detect;

    int a = 0;
    public int modeCount = 1;

    public void PressButton()
    {
        int count = 0;
        if ((CirGreen.GetComponent<UISprite>().enabled==true && CirYellow.GetComponent<UISprite>().enabled == false) || a==0)
        {
            //CirGreen.SetActive(false);
            CirGreen.GetComponent<UISprite>().enabled = false;
            CirGreen.transform.GetChild(0).GetComponent<UISprite>().enabled = false;
            CirGreen.transform.GetChild(1).GetComponent<UILabel>().enabled = false;

            //CirYellow.SetActive(true);
            CirYellow.GetComponent<UISprite>().enabled = true;
            CirYellow.transform.GetChild(0).GetComponent<UISprite>().enabled = true;
            CirYellow.transform.GetChild(1).GetComponent<UILabel>().enabled = true;

            count++;
            modeCount = 0;
        }
        if ((CirGreen.GetComponent<UISprite>().enabled == false && CirYellow.GetComponent<UISprite>().enabled == true && count == 0) || a==1)
        {
            Debug.Log("2");
            //CirGreen.SetActive(true);
            CirGreen.GetComponent<UISprite>().enabled = true;
            CirGreen.transform.GetChild(0).GetComponent<UISprite>().enabled = true;
            CirGreen.transform.GetChild(1).GetComponent<UILabel>().enabled = true;

            //CirYellow.SetActive(false);
            CirYellow.GetComponent<UISprite>().enabled = false;
            CirYellow.transform.GetChild(0).GetComponent<UISprite>().enabled = false;
            CirYellow.transform.GetChild(1).GetComponent<UILabel>().enabled = false;

            modeCount = 1;
        }
    }
    
    public void PopupOK()
    {
        PopupOK_detect.transform.GetChild(0).gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        //CirGreen = GameObject.Find("Circle(green)");
        //CirYellow = GameObject.Find("Circle(yellow)");
        //lightIcon = GameObject.Find("lighton");
        PopupOK_detect = GameObject.Find("PopupOK_detect");
        //PopupOK_detect.transform.GetChild(0).gameObject.SetActive(false);
        //CirGreen.SetActive(true);
        CirGreen.GetComponent<UISprite>().enabled = true;
        CirGreen.transform.GetChild(0).GetComponent<UISprite>().enabled = true;
        CirGreen.transform.GetChild(1).GetComponent<UILabel>().enabled = true;
        //CirYellow.SetActive(false);
        CirYellow.GetComponent<UISprite>().enabled = false;
        CirYellow.transform.GetChild(0).GetComponent<UISprite>().enabled = false;
        CirYellow.transform.GetChild(1).GetComponent<UILabel>().enabled = false;

        lightIcon.GetComponent<UITexture>().enabled = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Title")
        {
            CirGreen = GameObject.Find("Circle(green)");
            CirYellow = GameObject.Find("Circle(yellow)");
            lightIcon = GameObject.Find("lighton");
            PopupOK_detect = GameObject.Find("PopupOK_detect");
            //PopupOK_detect.transform.GetChild(0).gameObject.SetActive(false);

            md = GameObject.Find("moveDetect");
            if (modeCount == 1)
            {
                a = 0;
                CirGreen.GetComponent<UISprite>().enabled = true;
                CirGreen.transform.GetChild(0).GetComponent<UISprite>().enabled = true;
                CirGreen.transform.GetChild(1).GetComponent<UILabel>().enabled = true;

                CirYellow.GetComponent<UISprite>().enabled = false;
                CirYellow.transform.GetChild(0).GetComponent<UISprite>().enabled = false;
                CirYellow.transform.GetChild(1).GetComponent<UILabel>().enabled = false;
            }
            
            if (modeCount == 0)
            {
                a = 1;
                CirGreen.GetComponent<UISprite>().enabled = false;
                CirGreen.transform.GetChild(0).GetComponent<UISprite>().enabled = false;
                CirGreen.transform.GetChild(1).GetComponent<UILabel>().enabled = false;

                CirYellow.GetComponent<UISprite>().enabled = true;
                CirYellow.transform.GetChild(0).GetComponent<UISprite>().enabled = true;
                CirYellow.transform.GetChild(1).GetComponent<UILabel>().enabled = true;
            }
        }
        if (md.GetComponent<moveDetect>().moveDetectCount == 1)
        {
            //Debug.Log("moveDetectCount=" + md.GetComponent<moveDetect>().moveDetectCount);
            lightIcon.GetComponent<UITexture>().enabled = true;
            PopupOK_detect.transform.GetChild(0).gameObject.SetActive(true);
        }
        if (md.GetComponent<moveDetect>().moveDetectCount == 0)
        {
            lightIcon.GetComponent<UITexture>().enabled = false;
            //Debug.Log("moveDetectCount=" + md.GetComponent<moveDetect>().moveDetectCount);
        }
    }
}
