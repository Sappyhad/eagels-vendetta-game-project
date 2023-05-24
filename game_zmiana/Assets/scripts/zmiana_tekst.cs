using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zmiana_tekst : MonoBehaviour
{
    public Texture newTexture; 
    public Color highlightColor = Color.yellow;
    //public GameObject trash;
    private Color originalColor;
    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        originalColor = renderer.material.color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            renderer.material.color = highlightColor;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            renderer.material.color = originalColor;
        }
    }

    private void Update()
    {
        if (Input.GetKeyUp("e") && renderer.material.color == highlightColor)
        {
            renderer.material.mainTexture = newTexture;
            //trash.SetActive(true);
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}

