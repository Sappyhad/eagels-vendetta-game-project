using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomAttack : MonoBehaviour
{
    private GameObject heroes;
    private GameObject enem;
    public GameObject clicked;

    public void zatak()
    {
        StartCoroutine(atakbota());
    }
    IEnumerator atakbota()
    {
        yield return new WaitForSeconds(2);
        botAttack();
    }
    public void botAttack()
    {
        enem = GameObject.Find("/Characters/enemies");
        heroes = GameObject.Find("/Characters/heroes");
        int children = enem.transform.childCount;
        for (int i = 0; i < children; i++)
        {
            if (enem.transform.GetChild(i).GetComponent<tura>().turn == 1)
            {
                int childrenhe = heroes.transform.childCount;
                clicked = heroes.transform.GetChild(Random.Range(0, childrenhe)).gameObject;
                enem.transform.GetChild(i).GetComponent<srodek>().zatak(clicked, enem.transform.GetChild(i).gameObject, 1);
                enem.transform.GetChild(i).transform.GetComponent<sprite>().atak();
                int dmg = enem.transform.GetChild(i).transform.GetComponent<DMG>().dmg;
                clicked.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<HealthBar>().zaatakowano(dmg);
                clicked.transform.GetComponent<sprite>().zatak();
                clicked = null;
                GameObject.Find("/ButtonController").GetComponent<tura>().nextTurn();
            }

          
                
        }
    }
}
