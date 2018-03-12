using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour {

	public static Power insaa;

	public GameObject PowerUp;
	public GameObject barr;
	public GameObject barl;

	Rigidbody rby;

	float time=2f;

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
		//	StartCoroutine (start ());
			PowerUp.transform.localScale = new Vector3 (0.18f, 0.18f, 0);
			LaunchPowerL();
		}

		if(ScoreboardController.instance.playerRScore > 2 )
		{
			PowerUp.transform.localScale = new Vector3 (0.18f, 0.18f, 0);
			LaunchPowerR();
		}
	}

	void LaunchPowerL()
	{
	//	transform.position = Vector2.zero;
	//	Debug.Log ("lpower called");
		Vector3 launchDir = new Vector3 ();

		rby.velocity= new Vector3(7.0f,-3.0f,0);
	//	Debug.Log (launchDir);
	//	Debug.Log (rby.velocity);

	}
	
	void LaunchPowerR()
	{
		Vector3 launchDir = new Vector3 ();

		rby.velocity= new Vector3(-7.0f,-3.0f,0);

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

		//If it was one of the bats
		if (hitt.gameObject.name == "Pong-L") 
		{
		//	Debug.Log ("Bhatkanu");
			Destroy(PowerUp);
			barl.transform.localScale += new Vector3 (0, 0.75f, 0);
		//	Invoke(Donee,time);
		}

		if (hitt.gameObject.name == "Pong-R")
		{
		//	Debug.Log("Bhatkanu right");
			Destroy(PowerUp);
			barr.transform.localScale += new Vector3 (0, 0.75f, 0);
		}
	}
}
