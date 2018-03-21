using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour 
{
	Rigidbody2D rb;
	public GameObject bar;
	public int initspeed;
	public int speed;
	public Vector2 spawnValue;
	private bool restart;
	public int score=0;
	public int lives=3;

	public Text scores;
	public Text lifes;
	public Text Win;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (Pause ());
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (transform.position.y < -6) 
		{
			transform.position = spawnValue;
			rb.velocity = Vector2.zero;
			lives = lives - 1;
			lifes.text = lives.ToString();
			if (lives == 0) {	
				Win.text = "Game Over";
				Destroy (bar);
				Destroy (this);
			} else if (lives > 269) {
				Win.text = "Congrats!!! You won";
				Destroy (bar);
				Destroy (this);
			}
			bar.transform.position = new Vector2 (0,-4f);
			StartCoroutine (Pause ());
		}
		if(Input.GetKey(KeyCode.Keypad0))
		{StartCoroutine (Pause ());}
	}

	public void LaunchBall()
	{
		transform.position = spawnValue;

		float sidex = Random.value > 0.5f ? 1f : -1f;
		float sidey = Random.value> 0.25f ? 1f : 0.5f;
	//	Vector2 temp = new Vector2 (sidex, sidey);
		rb.velocity = new Vector2(sidex,sidey)* speed;
	}

	IEnumerator Pause()
	{
		yield return new WaitForSeconds(2f);
		LaunchBall ();
	}

	void OnTriggerEnter2D (Collider2D hit)
	{
		//If it was one of the bats
		if (hit.tag=="Bricks") 
		{
			Destroy (hit.gameObject);
			rb.velocity = new Vector2(rb.velocity.x,-rb.velocity.y);
			score =score+5;
			scores.text = score.ToString();
			Debug.Log (score);
		}
		if (hit.tag=="Wallss") 
		{
			rb.velocity = new Vector2(-rb.velocity.x,rb.velocity.y);
		}
		if (hit.tag=="Bar") 
		{
			rb.velocity = new Vector2(rb.velocity.x,-rb.velocity.y);

		}
	}
}
