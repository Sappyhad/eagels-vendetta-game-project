using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class skillBrek : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Sprite change;
    public Sprite normalAbility1;
    public Sprite normalAttack;
    public Sprite SBability;
    public Sprite Sbattack;
    public Sprite Sbdmg;
    public Sprite SBiddle1;
    public Sprite SBiddle2;
    public int skill1Atak = 0;
    public int skill2Atak = 0;
    private GameObject hand;
    private GameObject panel;
    private GameObject hand2;
    private int changed = 0;
    public RuntimeAnimatorController anim;
    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    public void silverek(GameObject a)
    {
        StartCoroutine(zmiana(a));
    }
    IEnumerator zmiana(GameObject a)
    {
        Vector3 boh = new Vector3(a.transform.position.x, a.transform.position.y, a.transform.position.z);
        hand = GameObject.Find("/Fields/Center/Hero");
        panel = GameObject.Find("/Canvas/PanelTlo");
        panel.SetActive(false);
        GameObject.Find("/CamManager").GetComponent<change>().toCenterCamera();
        a.gameObject.GetComponent<Animator>().enabled = false;
        a.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        a.transform.position = hand.transform.position;
        a.gameObject.GetComponent<DMG>().dmg = (int)(a.gameObject.GetComponent<DMG>().dmg * 1.5);
        GetComponent<sprite>().dmg = Sbdmg;
        GetComponent<sprite>().idle = SBiddle1;
        GetComponent<sprite>().attack = Sbattack;
        spriteRenderer.sprite = change;
        yield return new WaitForSeconds(1);
        spriteRenderer.sprite = GetComponent<sprite>().idle;

        a.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        panel.SetActive(true);
        GameObject.Find("/CamManager").GetComponent<change>().toMainCamera();
        a.transform.position = boh;
        a.gameObject.GetComponent<Animator>().enabled = true;
        GetComponent<Animator>().runtimeAnimatorController = anim;

        changed = 1;
    }

    public void ab2(GameObject a, GameObject b)
    {
        StartCoroutine(abi2(a,b));
    }
    IEnumerator abi2(GameObject a, GameObject b)
    {
        Vector3 boh = new Vector3(a.transform.position.x, a.transform.position.y, a.transform.position.z);
        Vector3 enemy = new Vector3(b.transform.position.x, b.transform.position.y, b.transform.position.z);
        b.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
        b.transform.GetChild(0).GetChild(1).gameObject.transform.GetComponent<TextMeshProUGUI>().text = (a.gameObject.GetComponent<DMG>().dmg
                   * a.gameObject.GetComponent<skille>().s2multiplier).ToString();
        hand = GameObject.Find("/Fields/Center/Hero");
        hand2 = GameObject.Find("/Fields/Center/Enemy");
        panel = GameObject.Find("/Canvas/PanelTlo");
        panel.SetActive(false);
        GameObject.Find("/CamManager").GetComponent<change>().toCenterCamera();
        a.gameObject.GetComponent<Animator>().enabled = false;
        b.gameObject.GetComponent<Animator>().enabled = false;
        a.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        b.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        a.transform.position = hand.transform.position;
        b.transform.position = hand2.transform.position;
        Debug.Log("XD");
        if(changed==0)
            spriteRenderer.sprite = normalAbility1;
        else
            spriteRenderer.sprite = SBability;

        yield return new WaitForSeconds(1);
        spriteRenderer.sprite = GetComponent<sprite>().idle;
        a.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        b.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        panel.SetActive(true);
        GameObject.Find("/CamManager").GetComponent<change>().toMainCamera();
        a.transform.position = boh;
        b.transform.position = enemy;
        a.gameObject.GetComponent<Animator>().enabled = true;
        b.gameObject.GetComponent<Animator>().enabled = true;
        b.transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
        // a.gameObject.GetComponent<Animator>().enabled = true;


    }
    //    public void Silver()
    //{

    //    GetComponent<sprite>().dmg = Sbdmg;
    //    //GetComponent<sprite>().idle = SBiddle1;
    //    GetComponent<sprite>().attack = Sbattack;

    //}

}
