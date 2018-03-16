using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerr : MonoBehaviour {

	public static Powerr insaa;

	public GameObject PowerUp;
	public GameObject barr;
	public GameObject barl;


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
			if (ScoreboardController.instance.playerLScore > 2) 
			{
				PowerUp.transform.localScale = new Vector3 (0.18f, 0.18f, 0);
				LaunchPowerR ();
			}

		if (ScoreboardController.instance.playerRScore > 2) {
			PowerUp.transform.localScale = new Vector3 (0.18f, 0.18f, 0);
			LaunchPowerL ();
		}
	}

	void LaunchPowerL()
	{
	//	transform.position = Vector2.zero;
	//	Debug.Log ("lpower called");
		Vector3 launchDir = new Vector3 ();
		rby.velocity= new Vector3(7.0f,-3.0f,0);
		//PowerUp.transform.position = new Vector3 (2f, 3f, 0f);	
	}
	
	void LaunchPowerR()
	{
		Vector3 launchDir = new Vector3 ();
		rby.velocity= new Vector3(-7.0f,-3.0f,0);
		//PowerUp.transform.position = new Vector3 (-1f, -2f, 0f);
	/*	timee -= Time.deltaTime;
		if(timee<=0.0f)
			barr.transform.localScale += new Vector3 (1.25f, 1.25f, 1);
		timee = 5f;
*/
	}
	
	void OnCollisionEnter (Collision hitt)
	{
		if (hitt.gameObject.name == "BoundaryTop") 
		{
				Debug.Log ("Top touched");			
			float speedXDirection = 0f;

			if (rby.velocity.x > 0f)
				speedXDirection = 8f;

			if (rby.velocity.x < 0f)
				speedXDirection = -8f;

			rby.velocity = new Vector3 (speedXDirection, -8f, 0f);

		}

		if (hitt.gameObject.name == "BoundaryDown") 
		{
			Debug.Log("Down touched");
			float speedYDirection = 0f;

			if (rby.velocity.x > 0f)
				speedYDirection = 9f;

			if (rby.velocity.x < 0f)
				speedYDirection = -9f;

			rby.velocity = new Vector3 (speedYDirection, 7f, 0f);

		}

		if (hitt.gameObject.name == "Pong-L") 
		{
		//		PowerUp.transform.localScale = new Vector3 (0f, 0f, 0f);
		//		PowerUp.transform.position = new Vector3 (11.0f, 0f, 0f);
				barl.transform.localScale += new Vector3 (0f, 0.75f, 0);
		   		Destroy (PowerUp);
		}

		if (hitt.gameObject.name == "Pong-R")
		{
		//	Debug.Log("Bhatkanu right");
			Destroy(PowerUp);
		//		PowerUp.transform.localScale = new Vector3 (0f, 0f, 0f);
		//	PowerUp.transform.position = new Vector3 (11.0f, 0f, 0f);
				barr.transform.localScale += new Vector3 (0f, 0.75f, 0);
		}
	}
}
