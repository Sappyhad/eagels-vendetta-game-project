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
   // public AudioClip[] soundClips;
   // public AudioSource audioSource;
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
                        heroes.transform.GetChild(i).GetComponent<srodek>().zatak(heroes.transform.GetChild(i).gameObject, clicked, 0);
                        heroes.transform.GetChild(i).transform.GetComponent<sprite>().atak();
                        double dmg = heroes.transform.GetChild(i).transform.GetComponent<DMG>().dmg;
                        clicked.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<HealthBar>().zaatakowano(dmg);
                        // AudioClip randomClip = soundClips[randomIndex];

                        // Odtwarzaj losowy dŸwiêk
                        //  audioSource.PlayOneShot(randomClip);

                        clicked.transform.GetComponent<sprite>().zatak();
                        clicked = null;
                    }
                }
                
                //heroes.transform.GetChild(i).GetComponent<randomAttack>().zatak();

            }
        }
        GameObject.Find("/ButtonController").GetComponent<tura>().nextTurn();
    }
    public void Skill1()
    {
       
        heroes = GameObject.Find("/Characters/heroes");
        int childrenhe = heroes.transform.childCount;
        for (int i = 0; i < childrenhe; i++)
        {
            if (heroes.transform.GetChild(i).GetComponent<tura>().turn == 1)
            {
                int atak = 0;
                if (heroes.transform.GetChild(i).name == "brek")
                {
                    atak = heroes.transform.GetChild(i).GetComponent<skillBrek>().skill1Atak;

                }
                if(heroes.transform.GetChild(i).name == "topik")
                {
                    atak = heroes.transform.GetChild(i).GetComponent<skilltopik>().skill1Atak;
                }

                if (atak == 0)
                {                    
                       heroes.transform.GetChild(i).GetComponent<skillBrek>().silverek(heroes.transform.GetChild(i).gameObject);                    
                }
                else
                {

                    if (clicked != null)
                    {
                        if (clicked.name != heroes.transform.GetChild(i).name && clicked.transform.parent.gameObject != heroes.transform.GetChild(i).parent.gameObject)
                        {
                            if (atak == 1)
                            {
                                heroes.transform.GetChild(i).GetComponent<skilltopik>().ab1(heroes.transform.GetChild(i).gameObject, clicked);
                            }

                            //heroes.transform.GetChild(i).GetComponent<srodek>().zatak(heroes.transform.GetChild(i).gameObject, clicked, 0, 1);
                            //heroes.transform.GetChild(i).transform.GetComponent<sprite>().atak();
                            double dmg = heroes.transform.GetChild(i).transform.GetComponent<DMG>().dmg;
                            double multi = heroes.transform.GetChild(i).transform.GetComponent<skille>().s1multiplier;
                            clicked.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<HealthBar>().zaatakowano(dmg * multi);

                            clicked.transform.GetComponent<sprite>().zatak();
                            clicked = null;
                        }
                    }
                }

                //heroes.transform.GetChild(i).GetComponent<randomAttack>().zatak();

            }
        }
        GameObject.Find("/ButtonController").GetComponent<tura>().nextTurn();
    }
    public void Skill2()
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
                        int atak = 0;
                        if (heroes.transform.GetChild(i).name == "brek")
                        {
                            atak = heroes.transform.GetChild(i).GetComponent<skillBrek>().skill2Atak;
                        }
                        if (heroes.transform.GetChild(i).name == "topik")
                        {
                            atak = heroes.transform.GetChild(i).GetComponent<skilltopik>().skill2Atak;
                        }
                        if (atak == 0)
                        {
                            if (heroes.transform.GetChild(i).name == "brek")
                            {
                                heroes.transform.GetChild(i).GetComponent<skillBrek>().ab2(heroes.transform.GetChild(i).gameObject, clicked);
                            }
                        }
                        if (atak == 1)
                        {                           
                             heroes.transform.GetChild(i).GetComponent<skilltopik>().ab2(heroes.transform.GetChild(i).gameObject, clicked);                            
                        }
                        // heroes.transform.GetChild(i).GetComponent<srodek>().zatak(heroes.transform.GetChild(i).gameObject, clicked, 0, 2);
                        //  heroes.transform.GetChild(i).transform.GetComponent<sprite>().atak();
                        double dmg = heroes.transform.GetChild(i).transform.GetComponent<DMG>().dmg;
                        double multi = heroes.transform.GetChild(i).transform.GetComponent<skille>().s2multiplier;
                        clicked.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<HealthBar>().zaatakowano(dmg*multi);

                        clicked.transform.GetComponent<sprite>().zatak();
                        clicked = null;
                    }
                }

               // heroes.transform.GetChild(i).GetComponent<randomAttack>().zatak();

            }
        }
        GameObject.Find("/ButtonController").GetComponent<tura>().nextTurn();
    }
}

