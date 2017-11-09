using System.Collections;
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
       // input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
     //   if (GetComponent<Rigidbody2D>().velocity.magnitude < maxSpeed)
   //     {
  //          GetComponent<Rigidbody2D>().AddForce(input * speed);
 //       }
		if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            FireProjectile();
        }
	}

    public void FireProjectile()
    {
         GameObject clone = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
         clone.GetComponent<Rigidbody2D>().velocity = (new Vector3(10, 0, 10));
    }
}
