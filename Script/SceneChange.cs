using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    TitleController sc;
    public void Model()
    {
        SceneManager.LoadScene("Model");
    }
    public void Title()
    {
        SceneManager.LoadScene("Title");
    }
    public void Scan()
    {
        SceneManager.LoadScene("Scan");
    }
    public void CI()
    {
        SceneManager.LoadScene("CI");
    }

}
