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

    public void Start()
    {
        len = hero.Length + enem.Length;
        characters = new GameObject[len];
        for(int i = 0; i < hero.Length; i++)
        {
            characters[2 * i] = hero[i];
        }
        for (int i = 0; i < enem.Length; i++)
        {
            characters[2 * i+1] = enem[i];
        }
        
    }
    public void nextTurn()
    {
        iterator++;
        if (iterator >= len)
        {
            iterator = 0;
        }
        for (int i = 0; i < len; i++)
        {
            characters[i].GetComponent<tura>().turn=0;
        }
        characters[iterator].GetComponent<tura>().turn = 1;
        
    }
}
