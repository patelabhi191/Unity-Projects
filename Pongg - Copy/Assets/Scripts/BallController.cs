using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
	Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		int xDirec = Random.Range (0, 2);
		int yDirec = Random.Range (0, 2);



		rb.velocity=new Vector3(5f,0f,0f);

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
