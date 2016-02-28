﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	//Basic attributes for the characters that can be edited in unity editor.
	public float acceleration;
	public float maxMovementSpeed;
	public float jumpHeight;
	public float doubleJumpHeight;

	//Variables for the character jumping
	bool grounded;
	bool hasJumped;
	bool doubleJump;
	bool doubleJumped;

	//Variables for charactermovement
	float inputValueX = 0;


	//Variables
	string direction = "Right";
	bool walking = false;

	// Use this for initialization
	void Start () 
	{
		grounded = false;
		hasJumped = false;
		doubleJump = true;
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(!grounded && rigidbody2D.velocity.y == 0) 
		{
			grounded = true;
			doubleJump = true;
		}
		
		if (Input.GetButtonDown ("JumpPlayer1"))
		{

			if (grounded)
				hasJumped = true;
			else if (doubleJump)
			{
				doubleJumped = true;
				doubleJump = false;
			}

		}

		inputValueX = Input.GetAxis ("HorizontalPlayer1");

		if (inputValueX > 0) 
		{
			direction = "Right";
		} 
		else if (inputValueX < 0) 
		{
			direction = "False";
		} 
		else 
		{

		}



	}

	void FixedUpdate ()
	{
		if(hasJumped)
		{
			rigidbody2D.AddForce(transform.up*jumpHeight);
			grounded = false;
			hasJumped = false;
		}

		if(doubleJumped)
		{
			rigidbody2D.AddForce(transform.up*doubleJumpHeight);
			grounded = false;
			doubleJumped = false;
		}

		if (inputValueX > 0)
			if (rigidbody2D.velocity.x < maxMovementSpeed)
				rigidbody2D.AddForce(transform.right * acceleration);
		
		if (inputValueX < 0)
			if (rigidbody2D.velocity.x > -maxMovementSpeed)
					rigidbody2D.AddForce(transform.right * -acceleration);


	}
	
}





































