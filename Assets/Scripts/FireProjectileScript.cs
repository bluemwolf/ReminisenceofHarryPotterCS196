﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectileScript : MonoBehaviour {

    public GameObject projectile;
    public float speed;
    private float maxSpeed = 5f;
    private Vector3 input;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            FireProjectile();
        }
	}

    public void FireProjectile()
    {
        if (GetComponent<PlayerController>().getPosition() == 0)
        {
            GameObject clone = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            clone.GetComponent<Rigidbody2D>().velocity = (new Vector3(-10, 0, 10));
            Destroy(clone, 2.0f);
        } else if (GetComponent<PlayerController>().getPosition() == 1)
        {
            GameObject clone = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            clone.transform.Rotate(Vector3.forward * -90);
            clone.GetComponent<Rigidbody2D>().velocity = (new Vector3(0, 10, 10));
            Destroy(clone, 2.0f);
        } else if (GetComponent<PlayerController>().getPosition() == 2)
        {
            GameObject clone = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            clone.GetComponent<Rigidbody2D>().velocity = (new Vector3(10, 0, 10));
            Destroy(clone, 2.0f);
        } else if (GetComponent<PlayerController>().getPosition() == 3)
        {
            GameObject clone = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            clone.transform.Rotate(Vector3.forward * -90);
            clone.GetComponent<Rigidbody2D>().velocity = (new Vector3(0, -10, 10));
            Destroy(clone, 2.0f);
        }
        
    }
}
