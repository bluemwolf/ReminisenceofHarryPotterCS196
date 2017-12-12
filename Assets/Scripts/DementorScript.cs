using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DementorScript : MonoBehaviour {


	public Rigidbody2D rb;
	public float randomness;
	public float factor;
	private float gravConst;
	public Vector2 vect;
	public GameObject player;
	private float agressiveness;



	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		randomness = 10;
		player = GameObject.Find("Player");
		gravConst = 0;
	
	}

	// Update is called once per frame
	void FixedUpdate () {

		Vector2 randVector = new Vector2(Random.Range(-randomness, randomness), Random.Range(-randomness, randomness));

		Vector2 agro = (player.transform.position - transform.position) * (agressiveness);

		rb.AddForce((randVector + agro + (rb.position * -gravConst ))  * factor);
		vect = rb.velocity;
	}
}
