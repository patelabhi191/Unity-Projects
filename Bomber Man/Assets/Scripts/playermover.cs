using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermover : MonoBehaviour {

	public GameObject BomberBhai;
	public float speed;

	// Use this for initialization
	void Start (){}

	// Update is called once per frame
	void Update ()
	{
		BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(0f,0f,0f);
		if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
		{
			BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(0f,speed,0f);
		}
		else if (Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow))
		{
			BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(0f,-speed,0f);
		}
		else if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
		{
			BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(speed,0f,0f);
		}
		else if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
		{
			BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(-speed,0f,0f);
		}

	}
		
}
