using UnityEngine;
using UnityEngine.SceneManagement;

public class wyl : MonoBehaviour
{
    public float sceneDuration = 10f; // Czas trwania sceny (w sekundach)

    private float elapsedTime = 0f; // Up³yniêty czas

    private void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= sceneDuration)
        {
            // Wy³¹cz bie¿¹c¹ scenê
            Application.Quit();
        }
    }
}
