﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int step;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // currentTile = room
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("w")){
            rb.MovePosition(rb.position + Vector2.up * step);
//            Debug.Log("moving up");
        }
        if(Input.GetKeyDown("s")){
            rb.MovePosition(rb.position+Vector2.down * step);
//            Debug.Log("moving down");
        }
        if(Input.GetKeyDown("a")){
            rb.MovePosition(rb.position + Vector2.left * step);
//            Debug.Log("moving left");
        }
        if(Input.GetKeyDown("d")){
            rb.MovePosition(rb.position+Vector2.right * step);
//            Debug.Log("moving right");
        }

    }
}