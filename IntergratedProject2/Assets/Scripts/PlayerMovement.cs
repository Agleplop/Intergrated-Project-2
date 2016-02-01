using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float movementSpeed;
	public float jumpHeight;
	bool grounded;
	bool hasJumped;
	bool doubleJump;


	// Use this for initialization
	void Start () 
	{
		grounded = false;
		hasJumped = false;
		doubleJump = false;
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * movementSpeed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * movementSpeed * Time.deltaTime;
		}

		if(!grounded && rigidbody2D.velocity.y == 0) 
		{
			grounded = true;
		}
		
		if (Input.GetKey(KeyCode.UpArrow) && (grounded || doubleJump)) 
		{
			if (doubleJump = false)
				doubleJump = true;
			else
				doubleJump = false;
			print (doubleJump);
			
			hasJumped = true;
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
		
	}
	
}





































