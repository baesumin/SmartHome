using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LoadTextureFromURL : MonoBehaviour {

    static Dictionary<string, Texture2D> m_dicTexture = new Dictionary<string,Texture2D>();
    static public void ClearCache()
    {
        m_dicTexture.Clear();
    }

    string m_url;
    public UITexture m_uiTexture = null;

     void Awake()
     {
         //m_uiTexture = GetComponent<UITexture>();
     }
       
    int index;
    private void Update()
    {
       /* if(Input.GetKey(KeyCode.LeftArrow))
        {
            index--;
            if (index < 0)
                index = m_dicTexture.Keys.Count - 1;            
            m_uiTexture.mainTexture =  m_dicTexture[keys[index]];
            m_uiTexture.MakePixelPerfect();
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            index++;
            if (index > m_dicTexture.Keys.Count -1)
                index = 0;
            m_uiTexture.mainTexture = m_dicTexture[keys[index]];
            m_uiTexture.MakePixelPerfect();
        }*/
    }
    List<string> keys;
    private void Start()
    {
        LoadTexture("https://nbamania.com/g2/data/cheditor5/1712/mania-done-20171202002830_ofnvuhke.jpg");
        //LoadTexture("http://bizon.kookmin.ac.kr/files/editor/1442382115824.jpeg");
        /*LoadTexture("https://image.fmkorea.com/files/attach/new/20170802/486616/425627500/729936320/e21fcbb238b5f122244a6e8bb5f461ec.jpg");
        LoadTexture("https://image.fmkorea.com/files/attach/new/20170802/486616/425627500/729936320/9ae995de4dfea4676cd5e0674c8630a7.jpg");
        LoadTexture("https://image.fmkorea.com/files/attach/new/20170802/486616/425627500/729936320/61727e8124066cf794b40efe4f41f787.png");
        keys = new List<string>();*/
    }     
    public void LoadTexture(string url) {
        if (m_uiTexture == null) {
            return;
        }
        m_url = url;
        if (m_dicTexture.ContainsKey(url))   {
            m_uiTexture.mainTexture = m_dicTexture[url];
        }
        else  {
            m_uiTexture.mainTexture = null;
            StartCoroutine("Coroutin_LoadTexture", url);
        }
    }
    IEnumerator Coroutin_LoadTexture(string url) {
        WWW www = new WWW(url);
        yield return www;        
        if (www.error != null) {
            Debug.LogError(www.error);
        }
        else if(www.isDone) {            
            if (!m_dicTexture.ContainsKey(url))
            {                
                m_dicTexture.Add(url, www.texture);
               // keys.Add(url);
            }
            
            if (m_url.Equals(url))
            {
                m_uiTexture.mainTexture = www.texture;
            }
            m_uiTexture.MakePixelPerfect();           
            
        }
        www.Dispose();        
    }
}
