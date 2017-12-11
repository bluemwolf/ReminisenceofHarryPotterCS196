using UnityEngine;
using System.Collections;

public class HurtEnemy : MonoBehaviour {
	void Start() {
	
	}

	void Update() {
	
	}
	
	void OnTriggerEnter2d(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			Destroy(other.gameObject);
		}
	}
}
