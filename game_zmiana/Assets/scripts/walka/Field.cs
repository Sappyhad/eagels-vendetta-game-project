using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Field : MonoBehaviour
{

    public int id;
    public bool empty;
    private void Awake()
    {
        empty = true;
    }

}
