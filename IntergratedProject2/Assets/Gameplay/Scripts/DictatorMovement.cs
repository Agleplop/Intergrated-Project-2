using UnityEngine;
using System.Collections;

public class DictatorMovement : MonoBehaviour {

	public float movementSpeed;
	public float maxMovementSpeed;

	// Use this for initialization
	void Start () 
	{
	
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.A))
		{
			rigidbody2D.AddForce(transform.right * -movementSpeed);
		}

		if (Input.GetKey(KeyCode.D))
		{
			rigidbody2D.AddForce(transform.right * movementSpeed);
		}

		if (Input.GetKey(KeyCode.W))
		{
			rigidbody2D.AddForce(transform.up * movementSpeed);
		}

		if (Input.GetKey(KeyCode.S))
		{
			rigidbody2D.AddForce(transform.up * -movementSpeed);
		}

		if (rigidbody2D.velocity.magnitude > maxMovementSpeed)
			rigidbody2D.velocity = rigidbody2D.velocity.normalized * maxMovementSpeed;



//		if (!Input.anyKey && rigidbody2D.drag < 10)
//			rigidbody2D.drag++;
//		else
//			rigidbody2D.drag = 0;


	}

}
