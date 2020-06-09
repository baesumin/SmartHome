using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ardunity;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pickingWindow : MonoBehaviour
{
    Ray m_ray;
    RaycastHit m_rayHit;
    GameObject m_selectObject;
    Vector3 m_orgPos;

    [SerializeField]
    GameObject Canvas;

    int count = 0;

    public GameObject GetPickObject()
    {
        m_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(m_ray, out m_rayHit, 1000f, -1))
        {
            return m_rayHit.collider.gameObject;
        }
        return null;
    }
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name=="Model")
        {
            Canvas = GameObject.Find("scrollPanel");

        }
        
        if (Input.GetMouseButtonDown(0))
        {
            
            int temp = 0;
            m_selectObject = GetPickObject();
            
            if (m_selectObject.name == "Blinder" && count ==0)
            {
                Canvas.transform.GetChild(0).gameObject.SetActive(true);
                count = 1;
                temp = 1;
            }
            if (m_selectObject.name == "Blinder" && count == 1 && temp == 0)
            {
                Canvas.transform.GetChild(0).gameObject.SetActive(false);
                count = 0;
            }
        }

        if (m_selectObject != null)
        {
            Debug.DrawRay(m_ray.origin, m_ray.direction * m_rayHit.distance, Color.red);
        }
    }
}
