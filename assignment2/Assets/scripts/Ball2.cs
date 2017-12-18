using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class Ball2 : MonoBehaviour
{

    static int p1Score;
    static int p2Score;
    Vector3 startPos;
    public Text p1ScoreText;
    public Text p2ScoreText;

    // Use this for initialization
    void Start()
    {

        //ball movement starts
        GetComponent<Rigidbody>().velocity = new Vector3(-6, 5, 0);
        //starting position is saved for when a goal is made
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        p1ScoreText.text = p1Score.ToString();
        p2ScoreText.text = p2Score.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {


        //if they ball collides to player 1's goal
        if (collision.gameObject.name == "P1Goal")
        {

            //player 2 gets +1 to score
            p2Score++;

            //if player 2's score is 3 or higher
            if (p2Score == 5)
            {
                SceneManager.LoadScene(3);
            }

            //ball position is reset
            transform.position = startPos;

            //ball moves to the opposite side of the player who scored
            GetComponent<Rigidbody>().velocity = new Vector3(6, 5, 0);

        }
        //if the ball collides to player 2's goal
        else if (collision.gameObject.name == "P2Goal")
        {

            //player 1 gets +1 to score
            p1Score++;

            //if player 1's score is 3 or higher
            if (p1Score == 5)
            {
                SceneManager.LoadScene(3);
            }

            //ball position is reset
            transform.position = startPos;

            //ball moves to the opposite side of the player who scored
            GetComponent<Rigidbody>().velocity = new Vector3(-6, 5, 0);

        }

    }

}

