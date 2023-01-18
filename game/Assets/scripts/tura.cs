using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tura : MonoBehaviour
{
    public int turn;
    public GameObject[] hero;
    public GameObject[] enem;
    public int iterator = 0;
    private GameObject[] characters;
    private int len;
    public AudioSource audio1;


    public void Start()
    {
        
        len = hero.Length + enem.Length;
        if (hero.Length == enem.Length + 1)
        {
            characters = new GameObject[len];
            Debug.Log("1");
            for (int i = 0; i < hero.Length; i++)
            {
                characters[2 * i] = hero[i];
            }
            for (int i = 0; i < enem.Length; i++)
            {
                characters[2 * i + 1] = enem[i];
            }
        }
        else
        {
            characters = new GameObject[len+1];
            for (int i = 0; i < hero.Length; i++)
            {
                characters[2 * i] = hero[i];
            }
            int it = 0;
            for(int i = 0; i < len; i++)
            {
                if (characters[i] == null)
                {
                    characters[i] = enem[it];
                    it++;
                }
                if (it >= enem.Length)
                {
                    it = 0;
                }
            }


        }
        
    }
    public void nextTurn()
    {
        iterator++;
        if (hero.Length == enem.Length + 1)
        {
            if (iterator >= len)
            {
                iterator = 0;
            }
            for (int i = 0; i < len; i++)
            {
                characters[i].GetComponent<tura>().turn = 0;
                //Debug.Log(characters[i].name);
            }
            characters[iterator].GetComponent<tura>().turn = 1;
        }
        else
        {
            if (iterator >= len+1)
            {
                iterator = 0;
            }
            for (int i = 0; i < len+1; i++)
            {
                characters[i].GetComponent<tura>().turn = 0;
                Debug.Log(characters[i].name);
            }
            characters[iterator].GetComponent<tura>().turn = 1;
        }
    

    }
}
