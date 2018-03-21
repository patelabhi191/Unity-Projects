using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMover : MonoBehaviour {

	public GameObject Bar;
	public int move;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Bar.GetComponent<Rigidbody2D>().velocity=new Vector2(0f,0f);
		if (Input.GetKey(KeyCode.D)|Input.GetKey(KeyCode.RightArrow))
		{
			Bar.GetComponent<Rigidbody2D>().velocity=new Vector2(move,0f);
		}
		else if (Input.GetKey(KeyCode.A)|Input.GetKey(KeyCode.LeftArrow))
		{
			Bar.GetComponent<Rigidbody2D>().velocity=new Vector2(-move,0f);
		}
		else
			Bar.GetComponent<Rigidbody2D>().velocity=new Vector2(0f,0f);
	}
}
