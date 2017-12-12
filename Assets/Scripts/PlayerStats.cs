using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int[] playerHealthLevels; //can set these in unity
    public int[] playerAttackLevels;

    public int healthXP = 0;
    public int currentPlayerMaxHealth;
    public int currentPlayerHealthLevel = 0;

    public int attackXP = 0;
    public int currentPlayerAttack;
    public int currentPlayerAttackLevel = 0;

    private PlayerHealth health;

	// Use this for initialization
	void Start () {
        health = FindObjectOfType<PlayerHealth>();
        currentPlayerMaxHealth = playerHealthLevels[0];
        currentPlayerAttack = playerAttackLevels[0];
	}
	
	// Update is called once per frame
	void Update () {
		if (healthXP >= 50) // some number to level up health
        {
            levelHealthUp();
        }
        if (attackXP >= 50)
        {
            levelAttackUp();
        }
	}

    public void levelHealthUp()
    {
        currentPlayerHealthLevel++;
        currentPlayerMaxHealth = playerHealthLevels[currentPlayerHealthLevel];
        health.maxHealth = currentPlayerMaxHealth;
        health.currentHealth += currentPlayerMaxHealth - playerHealthLevels[currentPlayerHealthLevel];
    }
    public void levelAttackUp()
    {
        currentPlayerAttackLevel++;
        currentPlayerAttack = playerAttackLevels[currentPlayerAttackLevel];
    }
}
