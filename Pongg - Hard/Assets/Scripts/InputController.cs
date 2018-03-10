using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
	public static InputController intance;

    public GameObject Leftbar;
    public GameObject Rightbar;


	// Use this for initialization
	void Start ()
    {
		intance = this;	
	}
	
	// Update is called once per frame
	void Update ()
    {
		Leftbar.GetComponent<Rigidbody>().velocity=new Vector3(0f,0f,0f);
		if (Input.GetKey(KeyCode.W))
        {
			Leftbar.GetComponent<Rigidbody>().velocity=new Vector3(0f,3.2f,0f);
        }
		else if (Input.GetKey(KeyCode.S))
        {
			Leftbar.GetComponent<Rigidbody>().velocity=new Vector3(0f,-3.2f,0f);
        }

		Rightbar.GetComponent<Rigidbody>().velocity=new Vector3(0f,0f,0f);
		if (Input.GetKey(KeyCode.UpArrow))
		{
			Rightbar.GetComponent<Rigidbody>().velocity=new Vector3(0f,3.2f,0f);
		}
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			Rightbar.GetComponent<Rigidbody>().velocity=new Vector3(0f,-3.2f,0f);
		}

    }
}
