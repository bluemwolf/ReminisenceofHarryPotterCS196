using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
	public float diagonalMoveModifier;
	private float currMoveSpeed;
	private bool playerMoving;
	private Vector2 lastMove;
	
	private Animator anim;	
	private Rigidbody2D rb2d;

    private int position; //for shooting the projectile

	private void Start()	
	{
		anim = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            position = 0;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            position = 1;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            position = 2;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            position = 3;
        }
    }

    private void FixedUpdate()
	{
		playerMoving = false;
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		// is the player moving?
		if (moveHorizontal != 0)
		{
			lastMove = new Vector2(moveHorizontal, 0f);
			playerMoving = true;
		}		
		if (moveVertical != 0)
		{
			lastMove = new Vector2(0f, moveVertical);
			playerMoving = true;
		}
		if (moveVertical != 0 && moveHorizontal != 0)
		{
			currMoveSpeed = speed * diagonalMoveModifier;
		} else {
			currMoveSpeed = speed;
		}
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		rb2d.velocity = (movement * currMoveSpeed);
		anim.SetFloat("MoveX", moveHorizontal);
		anim.SetFloat("MoveY", moveVertical);
		anim.SetFloat("LastX", lastMove.x);
		anim.SetFloat("LastY", lastMove.y);
		anim.SetBool("PlayerMoving", playerMoving);
	}

    public int getPosition()
    {
        return position;
    }
}
