using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupFadeOut : MonoBehaviour {
    UISprite m_alphaSpr;
	// Use this for initialization
	void Awake () {
        m_alphaSpr = GetComponentInChildren<UISprite>();      
    }
    public void StartFadeOut()
    {
        m_alphaSpr.alpha = 1f;
        StartCoroutine("FadeOut");
    }
    float m_duration;
    IEnumerator FadeOut()
    {
        while(true)
        {
            m_duration += Time.deltaTime;
            m_alphaSpr.alpha = Mathf.Lerp(1f, 0f, m_duration);
            if (m_alphaSpr.alpha <= 0f)
            {
                m_duration = 0f;
                yield break;
            }
            yield return null;
        }
    }
	// Update is called once per frame
	void Update () {
       
       // m_alphaSpr.alpha = Mathf.Lerp(1f, 0f, Time.time);


    }
}
