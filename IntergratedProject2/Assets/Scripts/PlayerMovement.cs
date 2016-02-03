using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	//Basic attributes for the characters that can be edited in unity editor.
	public float movementSpeed;
	public float maxMovementSpeed;
	public float jumpHeight;
	public float doubleJumpHeight;

	//Variables for the character jumping
	bool grounded;
	bool hasJumped;
	bool doubleJump;
	bool doubleJumped;


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

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			rigidbody2D.AddForce(transform.right * -movementSpeed);
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			rigidbody2D.AddForce(transform.right * movementSpeed);
		}

		if(!grounded && rigidbody2D.velocity.y == 0) 
		{
			grounded = true;
			doubleJump = true;
		}
		
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{

			if (grounded)
				hasJumped = true;
			else if (doubleJump)
			{
				doubleJumped = true;
				doubleJump = false;
			}

		}

		float speedDifference = 0;











//		if (rigidbody2D.velocity.x > maxMovementSpeed && rigidbody2D.velocity.x > 0)
//		{
//			speedDifference = rigidbody2D.velocity.x - 5;
//			rigidbody2D.AddForce(transform.right * -speedDifference);
//			print("speed difference: " + speedDifference);
//		}
//
//		if (rigidbody2D.velocity.x < maxMovementSpeed && rigidbody2D.velocity.x < 0)
//		{
//			speedDifference = rigidbody2D.velocity.x + 5;
//			rigidbody2D.AddForce(transform.right * speedDifference);
//		}
//





//		if (rigidbody2D.velocity.x > maxMovementSpeed)
//			rigidbody2D.velocity = rigidbody2D.velocity.normalized * maxMovementSpeed;
//
//		if (rigidbody2D.velocity.x < -maxMovementSpeed)
//			rigidbody2D.velocity = rigidbody2D.velocity.normalized * maxMovementSpeed;
//







//		print ("Speed: " + rigidbody2D.velocity.x);






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

//		rigidbody2D.velocity = Vector3.ClampMagnitude (rigidbody2D.velocity, maxMovementSpeed);
//










//		float x =  Mathf.Clamp(rigidbody2D.velocity.x, 0, maxMovementSpeed);
//		rigidbody2D.velocity = new Vector2(x, 0f);













	}
	
}





































