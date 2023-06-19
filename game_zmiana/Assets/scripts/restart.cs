using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public float bottomThreshold = -10f;

    private void Update()
    {
        if (transform.position.y < bottomThreshold)
        {
            RestartGame();
        }
    }

    private void RestartGame()
    {
        SceneManager.LoadScene("map");
    }
}

