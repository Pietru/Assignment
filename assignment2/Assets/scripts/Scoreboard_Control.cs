using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard_Control : MonoBehaviour {

    public static Scoreboard_Controller instance;


    public Text p1ScoreText;
    public Text p2ScoreText;

    public int p1Score;
    public int p2Score;

	// Use this for initialization
	void Start () {
		instance = this;
        p1Score = p2Score = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void GiveP1Point()
    {
        p1Score += 1;
        plScoreText.text = p1Score.ToString();
    }

    public void GiveP2Point()
    {
        p2Score += 1;
        p2ScoreText.text = p2Score.ToString();
    }
}
