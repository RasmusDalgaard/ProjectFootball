using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{

    private int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            Debug.Log("GOOOOAL!!!");
            Score++;
            Debug.Log("Score is: " + Score.ToString());
        }

    }

    // Update is called once per frame
    void Update()
    {
        


    }

}
