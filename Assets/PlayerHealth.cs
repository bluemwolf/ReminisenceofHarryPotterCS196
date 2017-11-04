using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//need to add script to player/object that has the health
public class PlayerHealth : MonoBehaviour {
    public int maxHealth = 100;
    public int currentHealth;
	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;  
	}
	
	// Update is called once per frame
	void Update () {
		if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
            //somehow make it look like it dies or display a message
        }
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
	}
    public void loseHealth(int dmg)
    {
        currentHealth -= dmg;
    }
    public void addHealth(int add)
    {
        currentHealth += add;
    }
}
