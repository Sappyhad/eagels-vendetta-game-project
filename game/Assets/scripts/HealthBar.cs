using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthBar : MonoBehaviour
{
    private const float MAX_HEALTH = 100f;
    public float health = MAX_HEALTH;
    private Image healthBar;
    public TMP_Text healthText;
    private float currentHealth;
    public bool isDead = false;
    public Sprite damaged;
    private Sprite normal;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        currentHealth = MAX_HEALTH;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = currentHealth / MAX_HEALTH;
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
    public void zaatakowano()
    {
            currentHealth -= 20;           
    }
    void Dead()
    {
        if (transform.parent.parent.parent.GetComponent<tura>().turn == 1) {
            GameObject.Find("/ButtonController").GetComponent<tura>().nextTurn();
        }
       
        isDead = true;
        
    }
}
