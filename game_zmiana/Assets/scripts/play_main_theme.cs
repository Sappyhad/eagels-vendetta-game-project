using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play_main_theme : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void baz()
    {
        SceneManager.LoadScene("map");
    }
    public void Quit()
    {
        Application.Quit();
    }
    
}
