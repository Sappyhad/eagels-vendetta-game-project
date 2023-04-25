using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{

    public GameObject main;
    public GameObject center;
    public void toMainCamera()
    {
        main.SetActive(true);
        center.SetActive(false);
    }
    public void toCenterCamera()
    {
        main.SetActive(false);
        center.SetActive(true);
    }

}
