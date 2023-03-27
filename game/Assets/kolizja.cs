using UnityEngine;
using UnityEngine.SceneManagement;


public class kolizja : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
}