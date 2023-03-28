using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zmiana_tekstury : MonoBehaviour
{
    public GameObject prefab;
    public GameObject drugiObiekt;

    void OnTriggerEnter(Collider other)
    {
        // Tworzy nowy obiekt w miejscu poprzedniego
        Instantiate(prefab, transform.position, transform.rotation);
        // Usuwa poprzedni obiekt
        Destroy(gameObject);
       // Destroy(gameObject);

  //      drugiObiekt.SetActive(true);
   //     gameObject.SetActive(false);
        

    }
}