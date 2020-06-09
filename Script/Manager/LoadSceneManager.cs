using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class LoadSceneManager : DontDestroy<LoadSceneManager> {
       
    public enum SCENE_STATE
    {
        None = -1,
        Ci,
        Title,
        Lobby,
        Game,      
    }
    SCENE_STATE m_state;
    SCENE_STATE m_loadState = SCENE_STATE.None;
    
    AsyncOperation m_loadTask;

    public void LoadScene(SCENE_STATE state)
    {
        if (m_loadState != SCENE_STATE.None)
            return;
        m_loadState = state;

        SceneManager.LoadScene(state.ToString());        
    }
    public void LoadSceneAsync(SCENE_STATE state)
    {
        if (m_loadState != SCENE_STATE.None)
            return;
        m_loadState = state;
        m_loadTask = SceneManager.LoadSceneAsync(state.ToString());
    }
    protected override void OnAwake()
    {
        base.OnAwake();
    }

    protected override void OnStart()
    {
        base.OnStart();
        m_state = SCENE_STATE.Title;
    }
    void PressEscape()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!PopupManager.Instance.OnKeyEscape(KeyCode.Escape))
            {
                switch(m_state)
                {
                    case SCENE_STATE.Title:
                        PopupManager.Instance.OpenPopupOKCancel("알림", "정말 게임을 종료 하시겠습니까?", ()=> {
#if UNITY_EDITOR
                            EditorApplication.isPlaying = false;
#else
                            Application.Quit();
#endif
                        }, null, "예", "아니오");
                        break;
                    case SCENE_STATE.Lobby:
                        PopupManager.Instance.OpenPopupOKCancel("알림", "타이틀 화면으로 돌아가시겠습니까?", () => {
                            PopupManager.Instance.ClosePopup();
                            LoadSceneAsync(SCENE_STATE.Title);
                        }, null, "예", "아니오");
                        break;
                    case SCENE_STATE.Game:
                        PopupManager.Instance.OpenPopupOKCancel("알림", "게임을 종료하고 로비 화면으로 돌아가시겠습니까?", ()=> {
                            PopupManager.Instance.ClosePopup();
                            LoadSceneAsync(SCENE_STATE.Lobby);
                        }, null, "예", "아니오");
                        break;
                }
            }
        }
    }
    private void OnLevelWasLoaded(int level)
    {
        Debug.Log("현재 로드된 씬 레벨 : " +level);
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("현재 액티브 씬 : " + scene.name + " 인덱스 : " + scene.buildIndex);
        if (scene.buildIndex == level)
        {
            if(scene.name.Equals(m_loadState.ToString()))
            {
                m_state = m_loadState;
                m_loadState = SCENE_STATE.None;
                PopupManager.Instance.OpenFadeOut();
            }
        }       
    }
    // Update is called once per frame
    void Update () {
		if(m_loadTask != null)
        {
            if(m_loadTask.isDone)
            {
                m_loadTask = null;                
            }
            else
            {
                Debug.Log(m_loadTask.progress * 100);
            }
        }
        PressEscape();
    }
}
