using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class srodek : MonoBehaviour
{

    private GameObject hand;
    private GameObject hand2;
    private GameObject panel;

    public void zatak(GameObject a, GameObject b, int who, int skill=0)
    {
        StartCoroutine(zaatakowano(a, b,who,skill));
    }
    IEnumerator zaatakowano(GameObject a, GameObject b, int who, int skill)
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
        a.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        b.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        a.transform.position = hand.transform.position;
        b.transform.position = hand2.transform.position;
        if(who== 0) { 
            b.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
            if(skill == 0)
                b.transform.GetChild(0).GetChild(1).gameObject.transform.GetComponent<TextMeshProUGUI>().text =(a.gameObject.GetComponent<DMG>().dmg).ToString();
            if (skill == 1)
                b.transform.GetChild(0).GetChild(1).gameObject.transform.GetComponent<TextMeshProUGUI>().text = (a.gameObject.GetComponent<DMG>().dmg 
                    * a.gameObject.GetComponent<skille>().s1multiplier).ToString();

            if (skill==2)
                b.transform.GetChild(0).GetChild(1).gameObject.transform.GetComponent<TextMeshProUGUI>().text = (a.gameObject.GetComponent<DMG>().dmg 
                    * a.gameObject.GetComponent<skille>().s2multiplier).ToString();
        } else
        {
            a.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
            a.transform.GetChild(0).GetChild(1).gameObject.transform.GetComponent<TextMeshProUGUI>().text= (b.gameObject.GetComponent<DMG>().dmg).ToString();
        }   
        yield return new WaitForSeconds(1);
        a.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        b.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
        panel.SetActive(true);
        GameObject.Find("/CamManager").GetComponent<change>().toMainCamera();
        a.transform.position = boh;
        b.transform.position = enemy;
        a.gameObject.GetComponent<Animator>().enabled = true;
        b.gameObject.GetComponent<Animator>().enabled = true;
        if (who == 0) 
        { 
            b.transform.GetChild(0).GetChild(1).gameObject.SetActive(false); 
        }
        else
        {
            a.transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
        }
    }
}
