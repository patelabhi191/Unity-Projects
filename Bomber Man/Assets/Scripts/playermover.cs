using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermover : MonoBehaviour {

	public GameObject BomberBhai;
	public GameObject Bomb;
	public GameObject BombF;
	public Text Win;

	private float xaxis;
    private float yaxis;
    public float speed;
	public Animator anim;
	public Animator ani;
	public float nextFire;
	private float myTime = 0.0f;

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
		myTime += Time.deltaTime;
		        
		if (Input.GetKey (KeyCode.Space) && myTime > nextFire)
		{		
			Blast ();
			myTime = 0f;
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
		Vector3 loc = new Vector3(Mathf.Round(BomberBhai.transform.position.x), Mathf.Round(BomberBhai.transform.position.y),0);
		Instantiate (Bomb, loc, Quaternion.Euler (0, 0, 0));

		Vector3 loc1 = new Vector3(loc.x+0.9f,loc.y,0);
		Vector3 loc2 = new Vector3(loc.x,loc.y+0.9f,0);
		Vector3 loc3 = new Vector3(loc.x-0.9f,loc.y,0);
		Vector3 loc4 = new Vector3(loc.x,loc.y-0.9f,0);
		Instantiate (BombF, loc2 , Quaternion.Euler (0, 0, 0));
		Instantiate (BombF, loc4 , Quaternion.Euler (0, 0, 180));
		BombF.transform.Rotate(0,0,90);
		Instantiate (BombF, loc1 , Quaternion.Euler (0, 0, 270));
		Instantiate (BombF, loc3 , Quaternion.Euler (0, 0, 90));
		BombF.transform.Rotate(0,0,270);

	}		
	void OnCollisionEnter2D (Collision2D hitt)
	{
		
		if (hitt.gameObject.tag == "Gate") 
		{
			Destroy (hitt.gameObject,3f);
		//	Destroy (this.gameObject,4.5f);
			Destroy (GameObject.FindWithTag("Wallss"));
			Win.text="You Won...";
		}
	}
}
