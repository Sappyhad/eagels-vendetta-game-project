using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ikonyPostaciPanelu : MonoBehaviour
{

    public Sprite icon;
    public Sprite Aa;
    public Sprite Skill1;
    public Sprite Skill2;
    private GameObject panel;

    void Update()
    {
        if (GetComponent<tura>().turn == 1)
        {
            panel = GameObject.Find("/Canvas/PanelTlo");
            if (icon != null)
            {
                panel.transform.GetChild(0).gameObject.SetActive(true);
                panel.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = icon;

            }
            else
            {
                panel.transform.GetChild(0).gameObject.SetActive(false);
            }
            if (Aa != null)
            {
                panel.transform.GetChild(1).gameObject.SetActive(true);
                panel.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = Aa;

            }
            else
            {
                panel.transform.GetChild(1).gameObject.SetActive(false);

            }
            if (Skill1 != null)
            {
                panel.transform.GetChild(2).gameObject.SetActive(true);
                panel.transform.GetChild(2).gameObject.GetComponent<Image>().sprite = Skill1;

            }
            else
            {
                panel.transform.GetChild(2).gameObject.SetActive(false);

            }
            if (Skill2 != null)
            {
                panel.transform.GetChild(3).gameObject.SetActive(true);
                panel.transform.GetChild(3).gameObject.GetComponent<Image>().sprite = Skill2;

            }
            else
            {
                panel.transform.GetChild(3).gameObject.SetActive(false);
            }
        }


    }



}
