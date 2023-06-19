using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void wyjdü()
    {
        SceneManager.LoadScene("credits");
    }

    public void napisy_menu()
    {
        SceneManager.LoadScene("end");
    }

    public void graj()
    {
        SceneManager.LoadScene("baza");
    }

}
