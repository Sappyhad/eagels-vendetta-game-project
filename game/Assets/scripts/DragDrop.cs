using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragDrop : MonoBehaviour, IPointerClickHandler{

    public bool is_clicked = false;
    public GameObject hand;
    public GameObject hand2;
    private GameObject parent;
    private GameObject parent2;
    public int now;
    public bool can = true;
    private bool changed = false;
  

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (can == true)
        {
            //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
            //Debug.Log(name + " Game Object Clicked!");
            is_clicked = true;
            parent = GameObject.Find("/Characters/heroes");
            int children = parent.transform.childCount;
            for (int i = 0; i < children; i++)
                if(parent.transform.GetChild(i).name != name)
                   parent.transform.GetChild(i).GetComponent<DragDrop>().changed = false;
            changed = true;
        }
    }
    private void check()
    {
        hand2 = GameObject.Find("/Fields/heroes/");
        int fld = hand2.transform.childCount;
        parent2 = GameObject.Find("/Characters/heroes");
        int children = parent2.transform.childCount;
        int where;
        for (int i = 0; i < fld; i++)
        {            
            hand2.transform.GetChild(i).GetComponent<Field>().empty = true;
            //Debug.Log(hand2.transform.GetChild(i).GetComponent<Field>().name + " " + hand2.transform.GetChild(i).GetComponent<Field>().empty);
        }
        for (int i = 0; i < children; i++)
        {
            where = parent2.transform.GetChild(i).GetComponent<DragDrop>().now;
            //Debug.Log("== " +where);
            if(where>0 && where <10)
                hand2.transform.GetChild(where-1).GetComponent<Field>().empty = false;
        }
        //for (int i = 0; i < fld; i++)
        //{
        //    Debug.Log(hand2.transform.GetChild(i).GetComponent<Field>().name + " " + hand2.transform.GetChild(i).GetComponent<Field>().empty);
        //}
    }
   
    public void Update()
    {       
        if (is_clicked == true && can == true && changed == true)
        {
            check();
            if (Input.GetKeyUp(KeyCode.Alpha1) && now != 1)
            {
                check();
               // Debug.Log("1");
                hand = GameObject.Find("/Fields/heroes/NW");
               // Debug.Log(hand.name+" ===== "+ hand.transform.GetComponent<Field>().empty);
                if (hand.transform.GetComponent<Field>().empty == true)
                {
                    now = 1;
                    hand.transform.GetComponent<Field>().empty = false;
                   // Debug.Log(hand.name + " =====2 " + hand.transform.GetComponent<Field>().empty);
                    transform.position = hand.transform.position + new Vector3((float)-0.25, (float)0.5, 0);
                }
            }
            if (Input.GetKeyUp(KeyCode.Alpha2) && now != 2)
            {
                //Debug.Log("2");
                hand = GameObject.Find("/Fields/heroes/N");
              //  Debug.Log(hand.name);
                if (hand.transform.GetComponent<Field>().empty == true)
                {
                    now = 2;
                    hand.transform.GetComponent<Field>().empty = false;
                    transform.position = hand.transform.position + new Vector3((float)-0.25, (float)0.5, 0);
                }
            }
            if (Input.GetKeyUp(KeyCode.Alpha3) && now != 3)
            {
               // Debug.Log("3");
                hand = GameObject.Find("/Fields/heroes/NE");
              //  Debug.Log(hand.name);
                if (hand.transform.GetComponent<Field>().empty == true)
                {
                    now = 3;
                    hand.transform.GetComponent<Field>().empty = false;
                    transform.position = hand.transform.position + new Vector3((float)-0.25, (float)0.5, 0);
                }
            }
            if (Input.GetKeyUp(KeyCode.Alpha4) && now != 4)
            {
              //  Debug.Log("4");
                hand = GameObject.Find("/Fields/heroes/W");
               // Debug.Log(hand.name);
                if (hand.transform.GetComponent<Field>().empty == true)
                {
                    now = 4;
                    hand.transform.GetComponent<Field>().empty = false;
                    transform.position = hand.transform.position + new Vector3((float)-0.25, (float)0.5, 0);
                }
            }
            if (Input.GetKeyUp(KeyCode.Alpha5) && now != 5)
            {
               // Debug.Log("5");
                hand = GameObject.Find("/Fields/heroes/C");
              //  Debug.Log(hand.name);
                if (hand.transform.GetComponent<Field>().empty == true)
                {
                    now = 5;
                    hand.transform.GetComponent<Field>().empty = false;
                    transform.position = hand.transform.position + new Vector3((float)-0.25, (float)0.5, 0);
                }
            }
            if (Input.GetKeyUp(KeyCode.Alpha6) && now != 6)
            {
              //  Debug.Log("6");
                hand = GameObject.Find("/Fields/heroes/E");
               // Debug.Log(hand.name);
                if (hand.transform.GetComponent<Field>().empty == true)
                {
                    now = 6;
                    hand.transform.GetComponent<Field>().empty = false;
                    transform.position = hand.transform.position + new Vector3((float)-0.25, (float)0.5, 0);
                }
            }
            if (Input.GetKeyUp(KeyCode.Alpha7) && now != 7)
            {
             //   Debug.Log("7");
                hand = GameObject.Find("/Fields/heroes/SW");
               // Debug.Log(hand.name);
                if (hand.transform.GetComponent<Field>().empty == true)
                {
                    now = 7;
                    hand.transform.GetComponent<Field>().empty = false;
                    transform.position = hand.transform.position + new Vector3((float)-0.25, (float)0.5, 0);
                }
            }
            if (Input.GetKeyUp(KeyCode.Alpha8) && now != 8)
            {
              //  Debug.Log("8");
                hand = GameObject.Find("/Fields/heroes/S");
             //   Debug.Log(hand.name);
                if (hand.transform.GetComponent<Field>().empty == true)
                {
                    now = 8;
                    hand.transform.GetComponent<Field>().empty = false;
                    transform.position = hand.transform.position + new Vector3((float)-0.25, (float)0.5, 0);
                }
                }
            if (Input.GetKeyUp(KeyCode.Alpha9) && now != 9)
            {
              //  Debug.Log("9");
                hand = GameObject.Find("/Fields/heroes/SE");
             //   Debug.Log(hand.name);
                if (hand.transform.GetComponent<Field>().empty == true)
                {
                    now = 9;
                    hand.transform.GetComponent<Field>().empty = false;
                    transform.position = hand.transform.position + new Vector3((float)-0.25, (float)0.5, 0);
                }
            }
        }
    }

}
