using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBlast : MonoBehaviour {

	public GameObject Bhai;
	public GameObject Bomb;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () 
	{
		rb.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnCollisionEnter2D (Collision2D hit)
	{
		if (hit.gameObject.tag == "Wallss") 
		{
			Destroy (hit.gameObject,3.5f);
			Destroy (this.gameObject,4.5f);
		}
	}
}
