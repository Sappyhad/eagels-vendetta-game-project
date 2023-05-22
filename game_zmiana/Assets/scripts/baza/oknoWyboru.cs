using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class oknoWyboru : MonoBehaviour, IPointerClickHandler
{


    public GameObject hand;
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log("Otworz okno wyboru postaci");       
        hand.SetActive(true);



    }



}
