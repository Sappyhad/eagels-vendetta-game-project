using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class oknoWyboru : MonoBehaviour, IPointerClickHandler
{
    public AudioSource audioSource;

    public GameObject hand;
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        audioSource.Stop();
        Debug.Log("Otworz okno wyboru postaci");       
        hand.SetActive(true);



    }



}
