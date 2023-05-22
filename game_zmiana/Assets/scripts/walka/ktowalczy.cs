using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ktowalczy : MonoBehaviour
{

    private GameObject hand;
    private GameObject hand2;


    public void select()
    {
        bool first = false;
        hand = team.instance.gameObject;
        hand2 = GameObject.Find("/Characters/heroes/");
        int children = hand.transform.childCount;
        int children2 = hand2.transform.childCount;
        Debug.Log(children2);
        for (int i = 0; i < children; i++)
        {
            for(int j = 0; j < children2; j++)
            {
                if(hand2.transform.GetChild(j).name == hand.transform.GetChild(i).name)
                {
                    hand2.transform.GetChild(j).gameObject.SetActive(true);
                }
                if (first == false)
                {
                    first = true;
                    hand2.transform.GetChild(j).gameObject.GetComponent<tura>().turn = 1;
                }
            }

            //Debug.Log(hand.transform.GetChild(i).gameObject.name);

        }
        for (int j = 0; j < children2; j++)
        {
            if (!hand2.transform.GetChild(j).gameObject.activeSelf)
            {
                Destroy(hand2.transform.GetChild(j).gameObject);
            }

        }
    }

}
