using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
    private GameObject hand;
    public GameObject button;
    public GameObject panel;
    private GameObject but;
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
        //hand = GameObject.Find("/Characters/brek_ingame");
       // hand.GetComponent<DragDrop>().can = !hand.GetComponent<DragDrop>().can;
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
        //but.transform.position = new Vector3(-300, 0, 0);
        Destroy(but);
    }

}
