using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play_main_theme : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("baza");
    }

    public void baz()
    {
        SceneManager.LoadScene("mapp");
    }
    public void Quit()
    {
        Application.Quit();
    }
    
}
