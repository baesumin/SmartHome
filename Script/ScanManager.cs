using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Ardunity;

public class ScanManager : MonoBehaviour
{
    [SerializeField]
    TextMesh tempText;
    [SerializeField]
    TextMesh humidText;
    [SerializeField]
    TextMesh alarmText;
    [SerializeField]
    TextMesh inclText;
    [SerializeField]
    GameObject tempAndHumid;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Scan")
        {
            tempText = GameObject.Find("tempText").GetComponent<TextMesh>();
            humidText = GameObject.Find("dustText").GetComponent<TextMesh>();
            alarmText = GameObject.Find("AlarmText").GetComponent<TextMesh>();
            inclText = GameObject.Find("inclinationText").GetComponent<TextMesh>();
            tempText.text = "온도 : " + tempAndHumid.GetComponent<DHT11>().temperature.ToString();
            humidText.text = "습도 : " + tempAndHumid.GetComponent<DHT11>().humidity.ToString();
        }
        
    }
}
