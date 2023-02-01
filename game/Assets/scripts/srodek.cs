using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class srodek : MonoBehaviour
{

    private GameObject hand;
    private GameObject hand2;
    private GameObject panel;

    public void zatak(GameObject a, GameObject b)
    {
        StartCoroutine(zaatakowano(a, b));
    }
    IEnumerator zaatakowano(GameObject a, GameObject b)
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
        a.transform.GetChild(0).gameObject.SetActive(false);
        b.transform.GetChild(0).gameObject.SetActive(false);
        a.transform.position = hand.transform.position;
        b.transform.position = hand2.transform.position;
        yield return new WaitForSeconds(1);
        a.transform.GetChild(0).gameObject.SetActive(true);
        b.transform.GetChild(0).gameObject.SetActive(true);
        panel.SetActive(true);
        GameObject.Find("/CamManager").GetComponent<change>().toMainCamera();
        a.transform.position = boh;
        b.transform.position = enemy;
        a.gameObject.GetComponent<Animator>().enabled = true;
        b.gameObject.GetComponent<Animator>().enabled = true;
    }
}
