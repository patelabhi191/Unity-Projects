using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPlant : MonoBehaviour {

	public GameObject Bhai;
	public GameObject Bomb;
	private float xaxis;
	private float yaxis;
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKey(KeyCode.Space))
			Instantiate(Bomb, Bhai.transform.position, Quaternion.Euler (0, 0, 0));
	}
}
