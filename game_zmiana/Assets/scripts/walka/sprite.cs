using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite dmg;
    public Sprite idle;
    public Sprite attack;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    public void zatak()
    {
        StartCoroutine(zaatakowano());
    }
    public void atak()
    {
        StartCoroutine(atakuje());
    }
    IEnumerator atakuje()
    {
        spriteRenderer.sprite = attack;
        yield return new WaitForSeconds(1);
        spriteRenderer.sprite = idle;
    }

    IEnumerator zaatakowano()
    {
        spriteRenderer.sprite = dmg;    
        yield return new WaitForSeconds(1);
        spriteRenderer.sprite = idle;
    }
   
}
