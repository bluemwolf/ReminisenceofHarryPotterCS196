using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHarryPotter : MonoBehaviour {


	private Rigidbody2D rb;
	public int factor;
	public HealthScript hs;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		hs = GameObject.Find ("HealthSlider").GetComponent<HealthScript> ();
	}
	


	//for physics or something???
	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		rb.velocity = movement * factor;

	}


	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Enemy") {
			hs.DoDamage ();
		}
			

	}
		
}
