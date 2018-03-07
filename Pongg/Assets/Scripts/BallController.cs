using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
	Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (Pause ());

		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		 
	}
	void LaunchBall()
	{
		int xDirection = Random.Range (0, 2);
		int yDirection = Random.Range (0, 3);

		Vector3 launchDirection = new Vector3 ();

		if (xDirection == 0) 
		{
			launchDirection.x = -4f;
		}
		if (xDirection == 1)
		{
			launchDirection.x = 4f;
		}

		if (yDirection == 0) 
		{
			launchDirection.y = -4f;
		}
		if (yDirection == 1)
		{
			launchDirection.y = 4f;
		}
		if (yDirection == 2) 
		{
			launchDirection.y = 0f;
		}


		rb.velocity=launchDirection;

	}

	IEnumerator Pause()
	{
		yield return new WaitForSeconds(2.5f);
		LaunchBall ();
	}

	void OnCollisionEnter (Collision hit)
	{

		if (hit.gameObject.name == "BoundaryTop") 
		{
		//	Debug.Log ("Top touched");			
			float speedInXDirection = 0f;

			if (rb.velocity.x > 0f)
				speedInXDirection = 4f;

			if (rb.velocity.x < 0f)
				speedInXDirection = -4f;

			rb.velocity = new Vector3 (speedInXDirection, -4f, 0f);

		}

		if (hit.gameObject.name == "BoundaryDown") 
		{
		//	Debug.Log("Down touched");
			float speedInXDirection = 0f;

			if (rb.velocity.x > 0f)
				speedInXDirection = 4f;

			if (rb.velocity.x < 0f)
				speedInXDirection = -4f;

			rb.velocity = new Vector3 (speedInXDirection, 4f, 0f);

		}

		//If it was one of the bats
		if (hit.gameObject.name == "Pong-L") 
		{
			Debug.Log("Left touched");
			rb.velocity = new Vector3 (6f, 0f, 0f);


			//Check if we hit lower half of the bat...
			if (transform.position.y - hit.gameObject.transform.position.y < -0.5)
			{
				rb.velocity = new Vector3 (4f, -4f, 0f);
			}
			//Check if we hit lower half of the bat...
			if (transform.position.y - hit.gameObject.transform.position.y > 0.5) 
			{
				rb.velocity = new Vector3 (4f, 4f, 0f);
			}
		}
		if (hit.gameObject.name == "Pong-R") 
		{
		//	Debug.Log("Right touched");
			rb.velocity = new Vector3 (-6f, 0f, 0f);


			//Check if we hit lower half of the bat...
			if (transform.position.y - hit.gameObject.transform.position.y < -0.5) {

				rb.velocity = new Vector3 (-4f, -4f, 0f);
			}
			//Check if we hit lower half of the bat...
			if (transform.position.y - hit.gameObject.transform.position.y > 0.5) {

				rb.velocity = new Vector3 (-4f, 4f, 0f);
			}  
		}

	

}

	
}
