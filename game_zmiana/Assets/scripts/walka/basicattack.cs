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

    public AudioClip[] soundClips;
    public AudioSource audioSource;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
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
                       
                        //heroes.transform.GetChild(i).gameObject.GetComponent<Animator>().enabled=false;
                        //clicked.transform.gameObject.GetComponent<Animator>().Play(0);
                        heroes.transform.GetChild(i).GetComponent<srodek>().zatak(heroes.transform.GetChild(i).gameObject, clicked, 0);
                        heroes.transform.GetChild(i).transform.GetComponent<sprite>().atak();
                        int dmg = heroes.transform.GetChild(i).transform.GetComponent<DMG>().dmg;
                        clicked.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<HealthBar>().zaatakowano(dmg);
                        
                        //clicked.transform.gameObject.GetComponent<Animator>().Play(1);
                        clicked.transform.GetComponent<sprite>().zatak();
                       // int randomIndex = Random.Range(0, soundClips.Length);
                       // AudioClip randomClip = soundClips[randomIndex];

                        // Odtwarzaj losowy dŸwiêk
                      //  audioSource.PlayOneShot(randomClip);
                        clicked = null;
                        //heroes.transform.GetChild(i).gameObject.GetComponent<Animator>().enabled = true;
                    }
                }
                
                heroes.transform.GetChild(i).GetComponent<randomAttack>().zatak();

            }
        }
       


        }
}

