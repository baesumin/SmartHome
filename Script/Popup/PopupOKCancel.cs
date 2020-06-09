using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupOKCancel : MonoBehaviour {

    [SerializeField]
    UILabel m_subjectLabel;
    [SerializeField]
    UILabel m_bodyLabel;
    [SerializeField]
    UILabel m_btnOKLabel;
    [SerializeField]
    UILabel m_btnCancelLabel;
    PopupManager.ButtonDelegate m_btnOKDel;
    PopupManager.ButtonDelegate m_btnCancelDel;
    public void SetUI(string subject, string body, PopupManager.ButtonDelegate btnOkFunc = null, PopupManager.ButtonDelegate btnCancelFunc = null, string btnOkStr = "OK", string btnCancelStr = "Cancel")
    {
        m_subjectLabel.text = subject;
        m_bodyLabel.text = body;
        m_btnOKLabel.text = btnOkStr;
        m_btnCancelLabel.text = btnCancelStr;
        m_btnOKDel = btnOkFunc;
        m_btnCancelDel = btnCancelFunc;
    }
    public void OnPressOK()
    {
        if (m_btnOKDel != null)
        {
            m_btnOKDel();
        }
        else
        {
            PopupManager.Instance.ClosePopup();
        }
    }
    public void OnPressCancel()
    {
        if(m_btnCancelDel != null)
        {
            m_btnCancelDel();
        }
        else
        {
            PopupManager.Instance.ClosePopup();
        }
    }
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
