using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProgressManager : MonoBehaviour
{
    [SerializeField]
    GameObject scrollPanel;

    public void OnEventButtonClick()
    {
        scrollPanel.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        scrollPanel.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
