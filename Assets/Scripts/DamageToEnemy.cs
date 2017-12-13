using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToEnemy : MonoBehaviour {

    public int damage = 5;
    private int realDamage;

    private PlayerStats stats;

	// Use this for initialization
	void Start () {
        stats = FindObjectOfType<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other) //deal damage to enemy (not sure when to use OnTrigger or OnCollision, see DamageToPlayer)
    {
        if (other.gameObject.tag == "Enemy") //whatever the enemy is called
        {
            realDamage = damage + stats.currentPlayerAttack;
            other.gameObject.GetComponent<EnemyHealth>().loseHealth(realDamage);
        }
    }
}
