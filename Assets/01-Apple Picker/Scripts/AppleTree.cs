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


    public float chanceToChangeDirection = 0.1f;


    public float secondsBetweenAppleDrop = 1f;

    void Start()
    {
    
    }

    void Update()
    {
        
    }

}