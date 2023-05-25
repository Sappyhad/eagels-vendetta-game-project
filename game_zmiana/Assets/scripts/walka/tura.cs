using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tura : MonoBehaviour
{
    public int turn;
    public GameObject[] hero;
    public GameObject[] enem;
    public int iterator = 0;
    private GameObject[] characters;
    private int len;
    public Sprite fieldTurn;
    public Sprite fieldNonTurn;
    private GameObject hand;
    
    public void Start()
    {
        GetComponent<ktowalczy>().select();
        
       
        //if (hero.Length == enem.Length + 1)
        //{
        //    characters = new GameObject[len];
        //    for (int i = 0; i < hero.Length; i++)
        //    {
        //        characters[2 * i] = hero[i];
        //    }
        //    for (int i = 0; i < enem.Length; i++)
        //    {
        //        characters[2 * i + 1] = enem[i];
        //    }
        //}
        //else
        //{
        //    characters = new GameObject[len+1];
        //    for (int i = 0; i < hero.Length; i++)
        //    {
        //        characters[2 * i] = hero[i];
        //    }
        //    int it = 0;
        //    for(int i = 0; i < len; i++)
        //    {
        //        if (characters[i] == null)
        //        {
        //            characters[i] = enem[it];
        //            it++;
        //        }
        //        if (it >= enem.Length)
        //        {
        //            it = 0;
        //        }
        //    }
        //}        
    }
    public void stworz()
    {
        len = hero.Length + enem.Length;

        characters = new GameObject[len];
        //hero.CopyTo(characters, 0);
        characters = (GameObject[])hero.Clone();
        characters = characters.Concat((GameObject[])enem.Clone()).ToArray();
        //enem.CopyTo(characters, hero.Length);
        System.Random random = new System.Random();
        characters = characters.OrderBy(x => random.Next()).ToArray();
        characters[0].GetComponent<tura>().turn = 1;
        foreach (var el in characters)
        {
            Debug.Log("SIEMAAA" + el);
        }
        int a = 0;
        foreach (var el in enem)
        {
            if (characters[0].name == el.name)
            {
                a = 1;
                break;
            }
        }
        if (a == 1)
        {
            characters[0].GetComponent<randomAttack>().zatak();
        }
    }
    public void Update()
    {
        if (hero.Length == 1 && hero[0] == null)
        {
            Debug.Log("Przegrales");
            //SceneManager.LoadScene("End");
            return;
        }

     
       if (enem.Length == 1 && enem[0] == null)
        {
            Debug.Log("Wygrales");
            for(int i=0; i < hero.Length; i++)
            {
                hand = team.instance.gameObject;
                int children = hand.transform.childCount;
                for (int j = 0; j < children; j++)
                {
                    if (hand.transform.GetChild(j).gameObject.name == hero[i].name)
                    {
                        hand.transform.GetChild(j).gameObject.transform.GetComponent<HPMap>().currentHealth = hero[i].transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<HealthBar>().currentHealth;
                        

                    }
                }
            }

            
            SceneManager.UnloadScene(PlayerPrefs.GetInt("where"));            
           
           
            return;
        }
        List<GameObject> myListHe = new List<GameObject>();
        for (int i = 0; i < hero.Length; i++)
        {
            if (hero[i] != null)
            {
                if (hero[i].transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<HealthBar>().isDead == true)
                {
                    Destroy(hero[i]);
                }
                else
                {
                    myListHe.Add(hero[i]);
                }
            }
        }
        if (myListHe.Count == 0)
        {
            return;
        }
        hero = new GameObject[myListHe.Count];
        
        int ite = 0;
        foreach(GameObject a in myListHe)
        {
            hero[ite] = a;
            ite++;
        }
        List<GameObject> myListEn = new List<GameObject>();
        for (int i = 0; i < enem.Length; i++)
        {
            if (enem[i] != null)
            {
                if (enem[i].transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<HealthBar>().isDead == true)
                {
                    Destroy(enem[i]);
                    //enem[i].gameObject.SetActive(false);
                }
                else
                {
                    myListEn.Add(enem[i]);
                }
            }
        }
        if (myListEn.Count == 0)
        {
            return;
        }

        enem = new GameObject[myListEn.Count];
        ite = 0;
        foreach (GameObject a in myListEn)
        {
            enem[ite] = a;
            ite++;
        }

        len = hero.Length + enem.Length;
        foreach (var el in characters)
        {
            Debug.Log("SIEMAAA22" + el);
        }

        if (characters[iterator].gameObject != null || characters[iterator].GetComponent<DragDrop>().can == false)
            {
                for (int i = 0; i < characters.Length; i++)
                {
                    if (characters[i].gameObject!=null && characters[i].GetComponent<tura>().turn == 1)
                    {
                        string nm = characters[i].transform.parent.name;
                        GameObject pole = GameObject.Find("/Fields/" + nm);
                        int ktore = characters[i].GetComponent<DragDrop>().now;
                        pole.transform.GetChild(ktore - 1).GetComponent<SpriteRenderer>().sprite = fieldTurn;
                        Color color = pole.transform.GetChild(ktore - 1).GetComponent<SpriteRenderer>().color;
                        color.a = 0.75f;
                        pole.transform.GetChild(ktore - 1).GetComponent<SpriteRenderer>().color = color;
                    }
                    if(characters[i].gameObject != null && characters[i].GetComponent<tura>().turn == 0)
                    {
                        string nm = characters[i].transform.parent.name;
                        GameObject pole = GameObject.Find("/Fields/" + nm);
                        int ktore = characters[i].GetComponent<DragDrop>().now;
                        pole.transform.GetChild(ktore - 1).GetComponent<SpriteRenderer>().sprite = fieldNonTurn;
                        Color color = pole.transform.GetChild(ktore - 1).GetComponent<SpriteRenderer>().color;
                        color.a = 0.1f;
                        pole.transform.GetChild(ktore - 1).GetComponent<SpriteRenderer>().color = color;

                    }
                    else
                    {
                    Debug.Log("error w oznaczeniu");
                    }
                }
            }
        
    }
  
    public void nextTurn()
    {
        Debug.Log("przed" + characters[iterator]);
        iterator++;
       
        if (iterator >= characters.Length)
        {
            iterator = 0;
        }
        Debug.Log("przed" + characters[iterator]);
        if (characters[iterator].gameObject !=null)
        {
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i].gameObject != null)
                {
                    characters[i].GetComponent<tura>().turn = 0;
                }
            }
            characters[iterator].GetComponent<tura>().turn = 1;
            int a = 0;
            foreach (var el in enem)
            {
                if (characters[iterator].name == el.name)
                {
                    a = 1;
                    break;
                }
            }
            if (a == 1)
            {
                characters[iterator].GetComponent<randomAttack>().zatak();
            }
        }
        else
        {
            Debug.Log("nastepna");
            nextTurn();
        }
        


    }
}
