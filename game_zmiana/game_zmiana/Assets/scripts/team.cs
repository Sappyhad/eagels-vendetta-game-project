using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class team : MonoBehaviour
{
    public static team instance;
    private GameObject hand;
    public GameObject hand2;
    Material m_Material;
    Renderer rend;
    private void Awake()
    {

        hand = kto.instance.gameObject;
        int children = hand.transform.childCount;
        int children2 = hand2.transform.childCount;

        for (int i = 0; i < children; i++)
        {
            Debug.Log("wybrany:"+ hand.transform.GetChild(i).name);
            for (int j =0 ; j < children2; j++) 
            { 
                if(hand.transform.GetChild(i).name == hand2.transform.GetChild(j).name)
                {
                    //Debug.Log(this.transform.GetChild(i).name);
                    m_Material= hand2.transform.GetChild(j).GetComponent<Renderer>().material;
                    //Debug.Log(m_Material);
                    rend = this.transform.GetChild(i).GetComponent<Renderer>();
                    rend.enabled = true;
                    rend.sharedMaterial = m_Material;
                    this.transform.GetChild(i).GetComponent<HPMap>().name = hand2.transform.GetChild(j).name;
                    break;
                }

            }
           
            
        }
        int children3 = this.transform.childCount;
        for (int i = children; i < children3; i++)
        {
            this.transform.GetChild(i).gameObject.SetActive(false);

        }
            instance = this;
        DontDestroyOnLoad(this.gameObject);
    }


}
