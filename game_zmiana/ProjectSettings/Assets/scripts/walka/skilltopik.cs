using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class skilltopik : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Sprite Ability1;
    public Sprite Ability2;
    public Sprite Ability22;        
    public int skill1Atak = 1;
    public int skill2Atak = 1;
    private GameObject hand;
    private GameObject panel;
    private GameObject hand2;
    public RuntimeAnimatorController anim;
    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    public void ab1(GameObject a, GameObject b)
    {
        StartCoroutine(abi1(a,b));
    }
    IEnumerator abi1(GameObject a, GameObject b)
    {
        Vector3 boh = new Vector3(a.transform.position.x, a.transform.position.y, a.transform.position.z);
        Vector3 enemy = new Vector3(b.transform.position.x, b.transform.position.y, b.transform.position.z);
        hand = GameObject.Find("/Fields/Center/Hero");
        hand2 = GameObject.Find("/Fields/Center/Enemy");
        panel = GameObject.Find("/Canvas/PanelTlo");
        b.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
        b.transform.GetChild(0).GetChild(1).gameObject.transform.GetComponent<TextMeshProUGUI>().text = (a.gameObject.GetComponent<DMG>().dmg
                    * a.gameObject.GetComponent<skille>().s1multiplier).ToString();
        panel.SetActive(false);
        GameObject.Find("/CamManager").GetComponent<change>().toCenterCamera();
        a.gameObject.GetComponent<Animator>().enabled = false;
        b.gameObject.GetComponent<Animator>().enabled = false;
        a.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        b.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        a.transform.position = hand.transform.position;
        b.transform.position = hand2.transform.position;
        spriteRenderer.sprite = Ability1;
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

    }

    public void ab2(GameObject a, GameObject b)
    {
        StartCoroutine(abi2(a,b));
    }
    IEnumerator abi2(GameObject a, GameObject b)
    {
        Vector3 boh = new Vector3(a.transform.position.x, a.transform.position.y, a.transform.position.z);
        Vector3 enemy = new Vector3(b.transform.position.x, b.transform.position.y, b.transform.position.z);
        hand = GameObject.Find("/Fields/Center/Hero");
        hand2 = GameObject.Find("/Fields/Center/Enemy");
        panel = GameObject.Find("/Canvas/PanelTlo");
        panel.SetActive(false);
        GameObject.Find("/CamManager").GetComponent<change>().toCenterCamera();

        a.gameObject.GetComponent<Animator>().enabled = false;
        b.gameObject.GetComponent<Animator>().enabled = false;
        b.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
        b.transform.GetChild(0).GetChild(1).gameObject.transform.GetComponent<TextMeshProUGUI>().text = (a.gameObject.GetComponent<DMG>().dmg
                    * a.gameObject.GetComponent<skille>().s2multiplier).ToString();
        a.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        b.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        a.transform.position = hand.transform.position;
        b.transform.position = hand2.transform.position;
        spriteRenderer.sprite = Ability2;    

        yield return new WaitForSeconds(1);
        spriteRenderer.sprite = Ability22;
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
    }
    //    public void Silver()
    //{

    //    GetComponent<sprite>().dmg = Sbdmg;
    //    //GetComponent<sprite>().idle = SBiddle1;
    //    GetComponent<sprite>().attack = Sbattack;

    //}

}
