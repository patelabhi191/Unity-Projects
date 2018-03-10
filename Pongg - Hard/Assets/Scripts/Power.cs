using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour {

	public static Power insaa;
	Rigidbody rby;

	// Use this for initialization
	void Start () 
	{
		insaa = this;
		rby = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if ((ScoreboardController.instance.playerLScore > 2) | (ScoreboardController.instance.playerRScore > 2)) 
		{
			transform.position = Vector3.zero;
			rby.velocity = Vector3.zero;
			LaunchPower ();
		}

	}


	void LaunchPower()
	{

		int xD = Random.Range (0, 2);
		int yD = Random.Range (0, 2);

		Vector3 launchDir = new Vector3 ();

		if (xD == 0) 
		{
			launchDir.x = -6f;
		}
		if (xD == 1)
		{
			launchDir.x = 7f;
		}

		if (yD == 0) 
		{
			launchDir.y = -6f;
		}
		if (yD == 1)
		{
			launchDir.y = 7f;
		}


		rby.velocity=launchDir;

	}

	void OnCollisionEnter (Collision hitt)
	{

		if (hitt.gameObject.name == "BoundaryTop") 
		{
				Debug.Log ("Top touched");			
			float speedXDirection = 0f;

			if (rby.velocity.x > 0f)
				speedXDirection = 6f;

			if (rby.velocity.x < 0f)
				speedXDirection = -6f;

			rby.velocity = new Vector3 (speedXDirection, -7f, 0f);

		}

		if (hitt.gameObject.name == "BoundaryDown") 
		{
				Debug.Log("Down touched");
			float speedYDirection = 0f;

			if (rby.velocity.x > 0f)
				speedYDirection = 6f;

			if (rby.velocity.x < 0f)
				speedYDirection = -6f;

			rby.velocity = new Vector3 (speedYDirection, 7f, 0f);

		}

		//If it was one of the bats
		if (hitt.gameObject.name == "Pong-L") 
		{
		/*	Vector3 scale = transform.localScale;
			scale.y = 2.5F;
			transform.localScale = scale;	
			Destroy (this);*/
		}

		if (hitt.gameObject.name == "Pong-R") {
	/*		Vector3 scale = transform.localScale;
			scale.y = 2.5F;
			transform.localScale = scale;	
			Destroy (this);*/
		}
	}
}
