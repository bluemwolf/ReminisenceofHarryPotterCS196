using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//need to add this script to enemy for collision
public class DoDamage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "insert name here")
        {
            collision.gameObject.GetComponent<Health>().LoseHealth(10); //some dmg
        }
    }
}
