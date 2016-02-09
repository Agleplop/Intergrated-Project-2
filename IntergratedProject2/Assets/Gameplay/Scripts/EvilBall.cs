using UnityEngine;
using System.Collections;

public class EvilBall : MonoBehaviour {

	int random;
	Vector3 target = new Vector3(0, 0, 0);
	public float moveSpeed;

	// Use this for initialization
	void Start () 
	{
		int random = Random.Range (0, 4);

		switch (random)
		{
		case 0:
			transform.position = new Vector3 (-12, Random.Range(-4, 10), -1);
			break;
		case 1:
			transform.position = new Vector3 ( Random.Range(-12, 12), 10, -1);
			break;
		case 2:
			transform.position = new Vector3 (12, Random.Range(-4, 10), -1);
			break;
		case 3:
			transform.position = new Vector3 ( Random.Range(-12, 12),-4, -1);
			break;

		default:
			break;

		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = Vector3.MoveTowards (transform.position, target, moveSpeed * Time.deltaTime);

		if (transform.position == target)
			Destroy(this.gameObject);
	}

	public void GetTarget(Vector3 t)
	{
		target = t;
	}
}
