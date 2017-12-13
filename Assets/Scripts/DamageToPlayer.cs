﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//need to add this script to enemy for collision
public class DamageToPlayer : MonoBehaviour {

    public int damage = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other) //when the player collides with an enemy, player loses health
    {
        if (other.gameObject.tag == "Player") //whatever the player object is called
        {
            other.gameObject.GetComponent<PlayerHealth>().loseHealth(damage);
        }
    }
}
