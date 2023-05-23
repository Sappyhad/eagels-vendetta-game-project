using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class wybierz : MonoBehaviour, IPointerClickHandler
{
    public AudioSource audioSource;
    public bool sel = false;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (sel == false)
        {
            
            RawImage image = transform.parent.transform.parent.GetComponent<RawImage>();
            var tempColor = image.color;
            tempColor.a = 1f;
            image.color = tempColor;
            sel = true;
            
        }
        
        else
        {
  
            RawImage image = transform.parent.transform.parent.GetComponent<RawImage>();
            var tempColor = image.color;
            tempColor.a = 0f;
            image.color = tempColor;
            sel= false;


        }

    }


}
