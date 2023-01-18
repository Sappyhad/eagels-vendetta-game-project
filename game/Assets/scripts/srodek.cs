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
        Vector3 cam = Camera.main.transform.position;
        Camera.main.transform.position = new Vector3(Camera.main.transform.position.x- 0.057f, Camera.main.transform.position.y - 3.999f, Camera.main.transform.position.z + 6);
        Camera.main.transform.Rotate(-18.112f, 0.938f, 1.422f);  
        a.transform.GetChild(0).gameObject.SetActive(false);
        b.transform.GetChild(0).gameObject.SetActive(false);
        a.transform.position = hand.transform.position;
        b.transform.position = hand2.transform.position;
        yield return new WaitForSeconds(1);
        a.transform.GetChild(0).gameObject.SetActive(true);
        b.transform.GetChild(0).gameObject.SetActive(true);
        panel.SetActive(true);
        Camera.main.transform.position=cam;
        Camera.main.transform.Rotate(18.112f, -0.938f, -1.422f);
        a.transform.position = boh;
        b.transform.position = enemy;
    }
}
