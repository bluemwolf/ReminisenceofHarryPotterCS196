using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DementorScript : MonoBehaviour {


	public Rigidbody2D rb;
	public float randMax;
	public float randMin;
	public float factor;
	public float gravConst;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void FixedUpdate () {

		Vector2 randVector = new Vector2(Random.Range(randMin, randMax), Random.Range(randMin, randMax));


		rb.AddForce((randVector + (rb.position * gravConst ) * factor);
	}
}
