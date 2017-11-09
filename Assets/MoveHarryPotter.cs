using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHarryPotter : MonoBehaviour {


	private Rigidbody2D rb;
	public int factor;
	public PlayerHealth ps;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		ps = GetComponent<PlayerHealth> ();
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
			ps.loseHealth (20);
		}
		if (coll.gameObject.tag == "Bleach") {
			ps.loseHealth (2);
		}

			

	}

}
