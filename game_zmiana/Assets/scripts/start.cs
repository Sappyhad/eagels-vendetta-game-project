using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("baza");
    }

    public void menu()
    {
        SceneManager.LoadScene("end");
    }
}
