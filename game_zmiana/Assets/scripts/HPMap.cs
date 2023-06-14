using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HPMap : MonoBehaviour
{
    private const float MAX_HEALTH = 100f;
    public float currentHealth;
    public string charname;
   // public Image gameOverImage;
    // Start is called before the first frame update
    void Start()
    {
       // name = charname;
    }

    // Update is called once per frame
    void Update()
    {
     if (currentHealth < 0)
        Resources.Load<Sprite>("Assets/ZGON.png");
        Application.Quit();

    }
}
