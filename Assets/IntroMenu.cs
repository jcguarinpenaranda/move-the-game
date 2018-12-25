using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroMenu : MonoBehaviour { 
    public void OnClickButtonStart()
    {
        SceneManager.LoadScene("World1_1");
    }

    public void OnClickButtonExit()
    {
        Application.Quit();
    }
}
