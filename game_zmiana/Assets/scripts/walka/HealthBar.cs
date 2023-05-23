using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthBar : MonoBehaviour
{
    private const double MAX_HEALTH = 100d;
    public double health = MAX_HEALTH;
    private Image healthBar;
    public TMP_Text healthText; 
    public double currentHealth;
    public bool isDead = false;
    public Sprite damaged;
    private Sprite normal;
    private GameObject hand;
    private GameObject hand2;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        hand = transform.parent.gameObject.transform.parent.gameObject.transform.parent.gameObject;
        hand2 = team.instance.gameObject;
        int children = hand2.transform.childCount;
        for(int i=0; i < children; i++)
        {
            if(hand2.transform.GetChild(i).gameObject.name == hand.name)
            {
                currentHealth = hand2.transform.GetChild(i).gameObject.transform.GetComponent<HPMap>().currentHealth;
                return;

            }
        }
        currentHealth = MAX_HEALTH;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = (float)currentHealth / (float)MAX_HEALTH;
        healthText.text = currentHealth.ToString() + " / "+MAX_HEALTH.ToString();
        if (currentHealth <= 0)
        {
            //if (isDead)
            //{
                
            //    return;
            //}
            
            Dead();
        }
       
    }
    public void zaatakowano(double dmg)
    {
        currentHealth -= dmg;
        Debug.Log(dmg);
    }
    void Dead()
    {
        if (transform.parent.parent.parent.GetComponent<tura>().turn == 1) {
            GameObject.Find("/ButtonController").GetComponent<tura>().nextTurn();
        }
       
        isDead = true;
        
    }
}
