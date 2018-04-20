using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermover : MonoBehaviour {

	public GameObject BomberBhai;
	public GameObject Bomb;
	public GameObject BombF;
	private float xaxis;
    private float yaxis;
    public float speed;
	public Animator anim;
	public Animator ani;

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
		xaxis = Input.GetAxis ("Horizontal");
		yaxis = Input.GetAxis ("Vertical");
		        
		if (Input.GetKey (KeyCode.Space))
		{		
			Blast ();
		}
	
		BomberBhai.GetComponent<Rigidbody2D>().velocity=new Vector3(0f,0f,0f);
		anim.SetFloat("x", xaxis);
		anim.SetFloat("y", yaxis);
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
	void Blast()
	{
		Instantiate (Bomb, BomberBhai.transform.position, Quaternion.Euler (0, 0, 0));
		Vector3 loc1 = new Vector3(BomberBhai.transform.position.x+0.8f,BomberBhai.transform.position.y,0);
		Vector3 loc2 = new Vector3(BomberBhai.transform.position.x,BomberBhai.transform.position.y+0.8f,0);
		Vector3 loc3 = new Vector3(BomberBhai.transform.position.x-0.8f,BomberBhai.transform.position.y,0);
		Vector3 loc4 = new Vector3(BomberBhai.transform.position.x,BomberBhai.transform.position.y-0.8f,0);
		Instantiate (BombF, loc2 , Quaternion.Euler (0, 0, 0));
		Instantiate (BombF, loc4 , Quaternion.Euler (0, 0, 180));
		BombF.transform.Rotate(0,0,90);
		Instantiate (BombF, loc1 , Quaternion.Euler (0, 0, 270));
		Instantiate (BombF, loc3 , Quaternion.Euler (0, 0, 90));
		BombF.transform.Rotate(0,0,270);
	}
		
}
