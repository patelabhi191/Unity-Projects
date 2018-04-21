using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBlast : MonoBehaviour {
	
	public GameObject Gate;
	private bool ad = true;
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}

	void OnCollisionEnter2D (Collision2D hit)
	{
		if (hit.gameObject.tag == "Wallss") 
		{
			Destroy (hit.gameObject,3.8f);
			Destroy (this.gameObject,4.5f);
		}
		if (hit.gameObject.name == "Gate") 
		{
			Destroy (hit.gameObject,3.8f);
			Destroy (this.gameObject,4.5f);
			Gate.transform.position =new Vector3(-8,-4,0);
		}
	}
}
