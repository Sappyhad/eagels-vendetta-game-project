using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ItemSlot : MonoBehaviour, IDropHandler
{
    private float movementSpeed = 5f;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if(eventData.pointerDrag != null)
        {             
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<RectTransform>().transform.position = eventData.pointerDrag.GetComponent<RectTransform>().transform.position +
            new Vector3(-5*movementSpeed*Time.deltaTime, 30*movementSpeed * Time.deltaTime, 0);
            
        }

    }


}
