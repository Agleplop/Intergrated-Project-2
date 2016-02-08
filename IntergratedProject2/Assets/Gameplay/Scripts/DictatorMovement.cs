using UnityEngine;
using System.Collections;

public class DictatorMovement : MonoBehaviour {

	public float movementSpeed;
	public float maxMovementSpeed;
	float inputValueX = 0;
	float inputValueY = 0;

	// Use this for initialization
	void Start () 
	{
	
	}

	// Update is called once per frame
	void Update () 
	{

		inputValueX = Input.GetAxis("HorizontalDictator");
		inputValueY = Input.GetAxis("VerticalDictator");

		if (rigidbody2D.velocity.magnitude > maxMovementSpeed)
			rigidbody2D.velocity = rigidbody2D.velocity.normalized * maxMovementSpeed;



		if (Input.GetAxis("HorizontalDictator") == 0 && Input.GetAxis("VerticalDictator") == 0 && rigidbody2D.drag < 10)
			rigidbody2D.drag++;
		else
			rigidbody2D.drag = 0;


	}

	void FixedUpdate ()
	{
		if (inputValueX > 0)
			rigidbody2D.AddForce(transform.right * movementSpeed);

		if (inputValueX < 0)
			rigidbody2D.AddForce(transform.right * -movementSpeed);

		if (inputValueY > 0)
			rigidbody2D.AddForce(transform.up * movementSpeed);

		if (inputValueY < 0)
			rigidbody2D.AddForce(transform.up * -movementSpeed);
	}

}

























