using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogMen : MonoBehaviour
{
    private GameObject hand;
    private GameObject brek;
    private Queue<string> sentences;
    public TextMeshProUGUI dialogText;
    public TextMeshProUGUI dialogText2;
    public GameObject panel1;
    public GameObject panel2;
    public TextMeshProUGUI dialImie;
    public TextMeshProUGUI dialImie2;
    public Sprite orzelgada;
    public Sprite orzelniegada;
    public Sprite dziadgada;
    public Sprite dziadniegada;
    public GameObject txt;
    public GameObject txt2;
    private string name1;
    private string name2;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(dialogdziadka dialogue)
    {
        Debug.Log("Start z " + dialogue.name);
        name1 = dialogue.name;
        name2 = dialogue.name2;

        sentences.Clear();



        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            DisplayNextSentence();
        }
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDial();
            return;
        }
        if (sentences.Count % 2 == 0)
        {
            brek = GameObject.Find("Orzel");
            hand = GameObject.Find("Sec");

            brek.GetComponent<Image>().sprite = orzelgada;
            hand.GetComponent<Image>().sprite = dziadniegada;

            panel1.SetActive(true);
            panel2.SetActive(false);

            dialImie.text = name2;
            //txt2.SetActive(false);
            //txt.SetActive(true);

            string sentence = sentences.Dequeue();
            dialogText.text = sentence;

        }
        else
        {
            brek = GameObject.Find("Orzel");
            hand = GameObject.Find("Sec");

            brek.GetComponent<Image>().sprite = orzelniegada;
            hand.GetComponent<Image>().sprite = dziadgada;

            panel1.SetActive(false);
            panel2.SetActive(true);

            dialImie2.text = name1;
            //txt.SetActive(false);
            //txt2.SetActive(true);

            string sentence = sentences.Dequeue();
            dialogText2.text = sentence;

        }

    }
    void EndDial()
    {
        hand = GameObject.Find("DialUI");
        hand.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        brek = GameObject.Find("Heroes");
        brek.transform.GetComponent<Controller>().enabled = true;
        GameObject.Find("ramka_dziadka").GetComponent<DialTrigger>().rozm = false;
    }

}