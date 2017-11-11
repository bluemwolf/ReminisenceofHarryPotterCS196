using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHarryPotter : MonoBehaviour {


	private Rigidbody2D rb;
	public int factor;
	public PlayerHealth ps;
    private int position;


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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            position = 0;
        } else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            position = 1;
        } else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            position = 2;
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            position = 3;
        }
    }

    public int getPosition()
    {
        return position;
    }

    void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Enemy") {
			ps.loseHealth (20);
		}
		if (coll.gameObject.tag == "Bleach") {
			ps.loseHealth (2);
		}
		if (coll.gameObject.tag == "Food") {
			ps.addHealth (50);
		}
			

	}

}
