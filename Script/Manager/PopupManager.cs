using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupManager : DontDestroy<PopupManager> {

    public delegate void ButtonDelegate();

    [SerializeField]
    GameObject m_okPopupPrefab;
    [SerializeField]
    GameObject m_okCancelPopupPrefab;
    [SerializeField]
    GameObject m_fadeoutPopupPrefab;
    int m_popupDepth = 1000;
    int m_popupDepthGap = 10;
    int m_fadeDepth = 2000;
    GameObject m_fadeOutObj;
    List<GameObject> m_popupList = new List<GameObject>();
    protected override void OnAwake()
    {
        m_okPopupPrefab = Resources.Load("Popup/PopupOK") as GameObject;
        m_okCancelPopupPrefab = Resources.Load("Popup/PopupOKCancel") as GameObject;
        m_fadeoutPopupPrefab = Resources.Load("Popup/PopupFadeOut") as GameObject;

        base.OnStart();
    }
    public void OpenPopupOK(string subject, string body, ButtonDelegate btnOkFunc = null, string btnOkstr = "OK")
    {
        var obj = Instantiate(m_okPopupPrefab) as GameObject;
        obj.transform.SetParent(transform);
        //obj.GetComponent<UIPanel>().depth = m_popupDepth + m_popupList.Count * m_popupDepthGap;
        var subPanels = obj.GetComponentsInChildren<UIPanel>();
        for(int i = 0; i < subPanels.Length; i++)
        {
            subPanels[i].depth = m_popupDepth + m_popupList.Count * m_popupDepthGap + i;
        }
        var popup = obj.GetComponent<PopupOK>();
        popup.SetUI(subject, body, btnOkFunc, btnOkstr);

        m_popupList.Add(obj);
    }
    public void OpenPopupOKCancel(string subject, string body, ButtonDelegate btnOkFunc = null, ButtonDelegate btnCancelFunc = null, string btnOkstr = "OK", string btnCancelStr = "Cancel")
    {
        var obj = Instantiate(m_okCancelPopupPrefab) as GameObject;
        obj.transform.SetParent(transform);
        var subPanels = obj.GetComponentsInChildren<UIPanel>();
        for (int i = 0; i < subPanels.Length; i++)
        {
            subPanels[i].depth = m_popupDepth + m_popupList.Count * m_popupDepthGap + i;
        }
        var popup = obj.GetComponent<PopupOKCancel>();
        popup.SetUI(subject, body, btnOkFunc, btnCancelFunc, btnOkstr, btnCancelStr);

        m_popupList.Add(obj);
    }
    public void OpenFadeOut()
    {
        if (m_fadeOutObj == null)
        {
            m_fadeOutObj = Instantiate(m_fadeoutPopupPrefab) as GameObject;
            m_fadeOutObj.transform.SetParent(transform);
        }
        m_fadeOutObj.GetComponent<UIPanel>().depth = m_fadeDepth;
        m_fadeOutObj.GetComponent<PopupFadeOut>().StartFadeOut();
    }
    public void ClosePopup()
    {
        if(m_popupList.Count > 0)
        {
            Destroy(m_popupList[m_popupList.Count - 1]);
            m_popupList.Remove(m_popupList[m_popupList.Count - 1]);            
        }
    }
    public bool OnKeyEscape(KeyCode keycode)
    {
        if (keycode == KeyCode.Escape && m_popupList.Count <= 0)
            return false;
        
            ClosePopup();
            return true;        
    }
    // Update is called once per frame
    void Update () {
		
	}
}
