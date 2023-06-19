using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startBattle1 : MonoBehaviour
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
        PlayerPrefs.SetInt("where", 3);
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("SimpleScene"));
        // SceneManager.LoadScene(3, LoadSceneMode.Additive);
        SceneManager.LoadScene("SampleScene");
    }
}
