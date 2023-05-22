using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kto : MonoBehaviour
{
    public static kto instance;
    public GameObject hand;
    public void wybrane()
    {
       // Debug.Log(hand.name);
        int children = hand.transform.childCount -1;
        for(int i = 0; i < children; i++)
        {
            GameObject hand2 = hand.transform.GetChild(i).GetChild(0).GetChild(0).gameObject;
            if(hand2.transform.GetComponent<wybierz>().sel==true)
            {
                hand2.transform.parent = this.transform;
                //Debug.Log(hand2.name);
            }


        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);

    }
}
