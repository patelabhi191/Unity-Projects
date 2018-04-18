using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermover : MonoBehaviour {

	public GameObject BomberBhai;
    private float xaxis;
    private float yaxis;
    public float speed;
	public Animator anim;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator>();
        anim.SetFloat("y", 0f);
        anim.SetFloat("x", 0f);
    }

	// Update is called once per frame
	void Update ()
	{
       xaxis = Input.GetAxis("Horizontal");
        yaxis = Input.GetAxis("Vertical");
        BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(0f,0f,0f);
        anim.SetFloat("x", xaxis);
        anim.SetFloat("y", yaxis);
        Debug.Log(xaxis);
        Debug.Log(yaxis);
         if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
         {
             BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(0f,speed,0f);
             //anim.SetFloat("y", yaxis);
         }
         else if (Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow))
         {
             BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(0f,-speed,0f);
             //anim.SetFloat("y", yaxis);
         }
         else if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
         {
             BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(speed,0f,0f);
            // anim.SetFloat("x", xaxis);
         }
         else if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
         {
             BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(-speed,0f,0f);
          //   anim.SetFloat("x", xaxis);
         }

    }
		
}
