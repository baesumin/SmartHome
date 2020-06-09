using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Lean.Touch;

public class DontdestroyHouse : MonoBehaviour
{
    [SerializeField]
    GameObject house;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        gameObject.GetComponent<LeanTwistRotateAxis>().enabled = false;
        gameObject.GetComponent<LeanPinchScale>().enabled = false;
        gameObject.GetComponent<LeanDragTranslate>().enabled = false;
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name=="Title")
        {
            gameObject.transform.position = new Vector3(0, 0, 0);
            gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            gameObject.GetComponent<LeanTwistRotateAxis>().enabled = false;
            gameObject.GetComponent<LeanPinchScale>().enabled = false;
            gameObject.GetComponent<LeanDragTranslate>().enabled = false;
        }

        if (SceneManager.GetActiveScene().name == "Model")
        {
            gameObject.GetComponent<LeanTwistRotateAxis>().enabled = true;
            gameObject.GetComponent<LeanPinchScale>().enabled = true;
            gameObject.GetComponent<LeanDragTranslate>().enabled = true;
        }

    }
}
