using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class BallController : MonoBehaviour {
	public static BallController inance;

	public GameObject Power;
	public GameObject BarLeft;
	public GameObject BarRight;

	int myIntt=0;
	int myInt=0;

	Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (Pause ());
		inance=this;
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (transform.position.x < -10) 
		{
			transform.position = Vector3.zero;
			rb.velocity = Vector3.zero;

			ScoreboardController.instance.PlayerLAPoint();
			StartCoroutine (Pause ());

		}
		if (transform.position.x > 10)
		{
			transform.position = Vector3.zero;
			rb.velocity = Vector3.zero;

			ScoreboardController.instance.PlayerRAPoint();
			StartCoroutine (Pause ());

		}
	}
	
		void LaunchBall()
		{
		transform.position = Vector3.zero;

		myInt = 0;
		myIntt = 0;

		int xDirection = Random.Range (0, 2);
		int yDirection = Random.Range (0, 3);

		Vector3 launchDirection = new Vector3 ();

		if (xDirection == 0) 
		{
			launchDirection.x = -3.75f;
		}
		if (xDirection == 1)
		{
			launchDirection.x = 3.75f;
		}

		if (yDirection == 0) 
		{
			launchDirection.y = -3.75f;
		}
		if (yDirection == 1)
		{
			launchDirection.y = 3.75f;
		}
		if (yDirection == 2) 
		{
			launchDirection.y = 0f;
		}


		rb.velocity=launchDirection;

		}

	IEnumerator Pause()
	{
		yield return new WaitForSeconds(2f);
		LaunchBall ();

	}

	void OnCollisionEnter (Collision hit)
	{

		if (hit.gameObject.name == "BoundaryTop") 
		{
		//	Debug.Log ("Top touched");			
			float speedInXDirection = 0f;

			if (rb.velocity.x > 0f)
				speedInXDirection = 3.2f;

			if (rb.velocity.x < 0f)
				speedInXDirection = -3.2f;

			rb.velocity = new Vector3 (speedInXDirection, -3.2f, 0f);

		}

		if (hit.gameObject.name == "BoundaryDown") 
		{
		//	Debug.Log("Down touched");
			float speedInXDirection = 0f;

			if (rb.velocity.x > 0f)
				speedInXDirection = 3.2f;

			if (rb.velocity.x < 0f)
				speedInXDirection = -3.2f;

			rb.velocity = new Vector3 (speedInXDirection, 3.2f, 0f);

		}

		//If it was one of the bats
		if (hit.gameObject.name == "Pong-L") 
		{
			Debug.Log(myInt);
			rb.velocity = new Vector3 (5.25f, 0f, 0f);
			myInt += 1;

			//Check if we hit lower half of the bat...
			if (transform.position.y - hit.gameObject.transform.position.y < -0.33)
			{
				rb.velocity = new Vector3 (3.2f, -3.2f, 0f);
			}
			//Check if we hit lower half of the bat...
			if (transform.position.y - hit.gameObject.transform.position.y > 0.33) 
			{
				rb.velocity = new Vector3 (3.2f, 3.2f, 0f);
			}

			if (myInt == 3) 
			{
				BarLeft.transform.localScale = new Vector3 (1.25f, 1.25f, 1);
				myInt = 0;
			}
		}
		if (hit.gameObject.name == "Pong-R") 
		{
			Debug.Log(myIntt);
			rb.velocity = new Vector3 (-5.25f, 0f, 0f);
			myIntt += 1;

			//Check if we hit lower half of the bat...
			if (transform.position.y - hit.gameObject.transform.position.y < -0.33) 
			{
				rb.velocity = new Vector3 (-3.2f, -3.2f, 0f);
			}
			//Check if we hit lower half of the bat...
			if (transform.position.y - hit.gameObject.transform.position.y > 0.33) 
			{
				rb.velocity = new Vector3 (-3.2f, 3.2f, 0f);
			}  
			if (myIntt == 3) 
			{
				BarRight.transform.localScale = new Vector3 (1.25f, 1.25f, 1);
				myInt = 0;
			}
		}
}
}
