using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
    public void ToMenu()
    {
        Config.Reset();
        SceneManager.LoadScene("MenuScene");
    }
}
