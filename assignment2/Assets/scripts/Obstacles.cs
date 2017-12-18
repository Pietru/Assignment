using UnityEngine;
using System.Collections;
public class Obstacles : MonoBehaviour
{
    public Transform farEnd;
    private Vector3 up;
    private Vector3 down;
    private float secondsForOneLength = 1f;

    void Start()
    {
        up = transform.position;
        down = farEnd.position;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(up, down,
         Mathf.SmoothStep(0f, 1f,Mathf.PingPong(Time.time / secondsForOneLength, 0.3f)
        ));
    }
}