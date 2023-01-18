using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
    private GameObject hand;
    public GameObject button;
    public GameObject panel;
    private GameObject but;
    public AudioSource audio;
    public AudioSource audio_v;
    public void Open()
    {
        if (button != null)
        {
            button.SetActive(true);
            
        }
        if (panel != null)
        {
            panel.SetActive(true);
            
        }
    }
    public void st()
    {
        Debug.Log("Koniec rozstawiania");
        hand = GameObject.Find("/Characters/enemies");
        int children = hand.transform.childCount;
        for (int i = 0; i < children; i++) { 
            hand.transform.GetChild(i).GetComponent<DragDrop>().can = false;
            Destroy(hand.transform.GetChild(i).GetComponent<DragDrop>());
        }
        hand = GameObject.Find("/Characters/heroes");
        children = hand.transform.childCount;
        for (int i = 0; i < children; i++)
        {
            hand.transform.GetChild(i).GetComponent<DragDrop>().can = false;
            Destroy(hand.transform.GetChild(i).GetComponent<DragDrop>());
        }
        but = GameObject.Find("StopButton");
        audio.Stop();
    //    audio_v.Play();
        Destroy(but);
    void Awake()
        {
            audio_v.Play();
        }
    }

}
