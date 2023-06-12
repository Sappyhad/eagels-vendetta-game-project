using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startBattle : MonoBehaviour
{
    //public static startBattle st;
    //private void Awake()
    //{
    //    st = this;
    //    DontDestroyOnLoad(this.gameObject);
    //}
    void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("SimpleScene"));
        PlayerPrefs.SetInt("where", 1);
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }
}
