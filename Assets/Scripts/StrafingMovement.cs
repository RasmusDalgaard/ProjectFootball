using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrafingMovement : MonoBehaviour
{
    private bool movingLeft;
    private float speed;
    private Transform playerPos;
    public float moveSpeed;


    void Start()
    {

        playerPos = GameObject.Find("GoalKeeper").transform;

    }

    void Update()
    {


        float move = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, playerPos.position, move);


    }
}


