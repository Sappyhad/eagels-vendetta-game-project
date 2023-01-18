using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class basicattack : MonoBehaviour, IPointerClickHandler
{
    private GameObject heroes;
    private GameObject enem;
    public GameObject clicked;
    private GameObject hand;
    private GameObject hand2;
    public void OnPointerClick(PointerEventData pointerEventData)
    {

        // Debug.Log(name + " Game Object Clicked!asdas");
        // Debug.Log(clicked.name);
        heroes = GameObject.Find("ButtonController");
        heroes.GetComponent<basicattack>().clicked = gameObject;
          
    }
    public void Atakuj()
    {
        heroes = GameObject.Find("/Characters/heroes");
        int childrenhe = heroes.transform.childCount;
        for (int i = 0; i < childrenhe; i++)
        {
            if (heroes.transform.GetChild(i).GetComponent<tura>().turn == 1)
            {
                if (clicked != null)
                {
                    if (clicked.name != heroes.transform.GetChild(i).name && clicked.transform.parent.gameObject != heroes.transform.GetChild(i).parent.gameObject)
                    {
                        heroes.transform.GetChild(i).GetComponent<srodek>().zatak(heroes.transform.GetChild(i).gameObject, clicked);
                        heroes.transform.GetChild(i).transform.GetComponent<sprite>().atak();
                        clicked.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<HealthBar>().zaatakowano();
                        clicked.transform.GetComponent<sprite>().zatak();
                        clicked = null;
                    }
                }

                heroes.transform.GetChild(i).GetComponent<randomAttack>().zatak();
            }
        }
       


        }
}

