using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour
{

    float y = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //keeps the paddle from going out of the screen
        if (y <= 4f)
        {

            //if key input is 'd'
            if (Input.GetKey("d"))
            {

                //paddle moves up
                y += 0.2f;

            }

        }
        if (y >= -4f)
        {
            //if key input is 'c'
            if (Input.GetKey("c"))
            {
                //paddle moves down
                y -= 0.2f;


            }
        }

        this.transform.position = new Vector3(this.transform.position.x, y, this.transform.position.z);

    }
}

