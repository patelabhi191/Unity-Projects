using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallStart : MonoBehaviour {

	public GameObject Wall;
	public float plcex;
	public float plcey;
	public float endx;
	public float endy;

	// Use this for initialization
	void Start () 
	{
		//outer walls
		for (float i = plcex; i < endx; i++) {
			Instantiate (Wall, new Vector3 (i, 5, 0), Quaternion.Euler (0, 0, 0));
			Instantiate (Wall, new Vector3 (i, -5, 0), Quaternion.Euler (0, 0, 0));
		}
		for (float i = plcey; i < endy; i++) {
			Instantiate (Wall, new Vector3 (9, i, 0), Quaternion.Euler (0, 0, 0));
			Instantiate (Wall, new Vector3 (-9, i, 0), Quaternion.Euler (0, 0, 0));
		}

		//inner bocks
		for (float i = -7; i < 8; i = i + 2) {
			for (float j = -3; j < 4; j = j + 2)
				Instantiate (Wall, new Vector3 (i, j, 0), Quaternion.Euler (0, 0, 90));
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
