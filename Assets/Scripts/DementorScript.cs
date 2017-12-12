using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DementorScript : MonoBehaviour {

	public float gravityConstant;
	public Rigidbody rb;
	public float randMax;
	public float randMin;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void FixedUpdate () {

		Vector2 randVector = new Vector2(Random.range(randMin, randMax), Random.range(randMin, randMax));


		rb.AddForce(randVector);
	}
}
