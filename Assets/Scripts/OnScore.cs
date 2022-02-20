using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnScore : MonoBehaviour
{
    private Vector3 initialBallPosition;
    private Vector3 initialPlayerPosition;
    private int Score = 0;

    private GameObject ball;
    private GameObject player;
    private Rigidbody rb;

    void Start()
    {
        ball = GameObject.Find("Ball");
        player = GameObject.Find("FPSController");
        rb = ball.GetComponent<Rigidbody>();

        initialBallPosition = ball.transform.position;
        initialPlayerPosition = player.transform.position;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Goal")
        {
            Debug.Log("GOOOOAL!!!");
            Score++;
            Debug.Log("Score is: " + Score.ToString());

            //Reset player position
            player.transform.position = initialPlayerPosition;

            //Reset ball position
            ball.transform.position = initialBallPosition;

            //Stop ball velocity
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            //Add to text

        }

    }

    void Update()
    {
    }
}
