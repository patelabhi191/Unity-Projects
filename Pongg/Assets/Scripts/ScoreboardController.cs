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

		playerLScore += 1;
		playerLeftScoreText.text = playerLScore.ToString();

		if (playerLScore > 10) 
		{
			playerWinner.text = "Player 1 Wins";
			crash ();
		}
	}
	public void PlayerRAPoint ()
	{

		playerRScore += 1;

		playerRightScoreText.text = playerRScore.ToString();
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
		Destroy (BallController.inance);

	}
}

