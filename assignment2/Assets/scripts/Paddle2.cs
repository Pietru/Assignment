using UnityEngine;
using System.Collections;

public class Paddle2 : MonoBehaviour
{

    float y = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (y <= 4f)
        {
            //if key input is 'up arrow'
            if (Input.GetKey("up"))
            {
                //paddle moves up
                y += 0.2f;

            }

        }
        if (y >= -4f)
        {
            //if key input is 'down arrow'
            if (Input.GetKey("down"))
            {
                //paddle moves down
                y -= 0.2f;

            }
        }
        this.transform.position = new Vector3(this.transform.position.x, y, this.transform.position.z);

    }

}
