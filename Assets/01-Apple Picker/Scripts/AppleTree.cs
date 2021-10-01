using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    // Prefab for instantiating apples
    public GameObject applePrefab;

    // Speed at which the AppleTree moves
    public float speed = 1f;

    // Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;


    public float chanceToChangeDirections = 0.1f;


    public float secondsBetweenAppleDrop = 1f;

    void Start()
    {
        //dropping apples every second
        Invoke("DropApple", 2f);
    }

    void DropApple() {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrop);
    }



    void Update()
    {
        // Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        /// Changing Direction
        /// 
        if ( pos.x< -leftAndRightEdge) {

            speed = Mathf.Abs(speed); //move right

        } else if ( pos.x > leftAndRightEdge){

            speed = -Mathf.Abs(speed);

        } 
    }

    void FixedUpdate()
    {


        //Changing Direction Randomly is now time based
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;

        }

    }

}