using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class DialTrigger : MonoBehaviour
{
    public Material material;
    private bool aa=false;
    public bool rozm=false;
    private GameObject hand;
    private GameObject brek;

    public dialogdziadka dialogue;

    void OnCollisionEnter(Collision collision)
    {
        transform.GetComponent<MeshRenderer>().enabled = true;
        Debug.Log("Dotyka");

        aa= true;


    }
    void OnCollisionExit(Collision collisionInfo)
    {
        Debug.Log("No longer in contact with " + collisionInfo.transform.name);
        transform.GetComponent<MeshRenderer>().enabled = false;
        aa= false;
    }
    void Update()
    {
        if (Input.GetKeyUp("e")&& aa==true &&rozm==false)
        {
            Debug.Log("siema");
            rozm = true;
            DialogSt();
            
        }
    }

    void DialogSt()
    {
        hand = GameObject.Find("DialUI");
        hand.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        brek = GameObject.Find("Brek");
        brek.transform.GetComponent<Controller>().enabled = false;
        FindObjectOfType<DialogMen>().StartDialogue(dialogue);
        
    }
}
