using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ScoreboardController : MonoBehaviour {

	public static ScoreboardController instance;

	public Text playerLeftScoreText;
	public Text playerRightScoreText;
	public Text playerWinner;

	public int playerLScore;
	public int playerRScore;	

	public GameObject Bar1;
	public GameObject Bar2;
	public GameObject Ball;

	// Use this for initialization
	void Start () 
	{
		instance = this;
		playerLScore = playerRScore = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	public void PlayerLAPoint ()
	{
		if (playerLScore > 10) 
		{
			playerWinner.text = "Player 1 Wins";
			crash ();
		}
	}
	public void PlayerRAPoint ()
	{
		if (playerRScore > 10) 
		{
			playerWinner.text = "Player 2 Wins";
			crash ();
		}

	}
	public void crash()
	{
		
		Destroy(InputController.intance.Leftbar);
		Destroy(InputController.intance.Rightbar);
		Destroy(BallController.inance);
		Destroy (Bar2);
		Destroy (Bar1);
		Destroy (Ball);
	}
}

