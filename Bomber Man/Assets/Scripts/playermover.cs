using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermover : MonoBehaviour {

	public GameObject BomberBhai;
	public float speed;
	public Animator anim;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update ()
	{
		BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(0f,0f,0f);
		if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
		{
			BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(0f,speed,0f);
			anim.SetBool ("IsRight",false);anim.SetBool ("IsLeftt",false);anim.SetBool ("IsDown",false);
			anim.SetBool ("IsUp",true);
		}
		else if (Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow))
		{
			BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(0f,-speed,0f);
			anim.SetBool ("IsRight",false);anim.SetBool ("IsLeftt",false);anim.SetBool ("IsUp",false);
			anim.SetBool ("IsDown",true);
		}
		else if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
		{
			BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(speed,0f,0f);
			anim.SetBool ("IsUp",false);anim.SetBool ("IsLeftt",false);anim.SetBool ("IsDown",false);
			anim.SetBool ("IsRight",true);
		}
		else if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
		{
			BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(-speed,0f,0f);
			anim.SetBool ("IsRight",false);anim.SetBool ("IsUp",false);anim.SetBool ("IsDown",false);
			anim.SetBool ("IsLeft",true);
		}

	}
		
}
