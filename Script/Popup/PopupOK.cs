using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupOK : MonoBehaviour {
    [SerializeField]
    UILabel m_subjectLabel;
    [SerializeField]
    UILabel m_bodyLabel;
    [SerializeField]
    UILabel m_btnOKLabel;
    PopupManager.ButtonDelegate m_btnOKDel;
    public void SetUI(string subject, string body, PopupManager.ButtonDelegate btnOkFunc = null, string btnOkStr = "OK")
    {
        m_subjectLabel.text = subject;
        m_bodyLabel.text = body;
        m_btnOKLabel.text = btnOkStr;
        m_btnOKDel = btnOkFunc;
    }
    public void OnPressOK()
    {
        if(m_btnOKDel != null)
        {
            m_btnOKDel();
        }
        else
        {
            PopupManager.Instance.ClosePopup();
        }
    }
	// Use this for initialization
	void Start () {        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
