using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int step;
    public Sprite upSprite;
    public Sprite downSprite;
    public Sprite sideSprite;
    private SpriteRenderer playerSprite;
    private Rigidbody2D rb;

    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        // currentTile = room
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("w"))
        {
            playerSprite.sprite = upSprite;
            playerSprite.flipX = false;
            rb.MovePosition(rb.position + Vector2.up * step);
//            Debug.Log("moving up");
        }
        if(Input.GetKeyDown("s")){
            playerSprite.sprite = downSprite;
            playerSprite.flipX = false;
            rb.MovePosition(rb.position+Vector2.down * step);
//            Debug.Log("moving down");
        }
        if(Input.GetKeyDown("a")){
            playerSprite.sprite = sideSprite;
            playerSprite.flipX = true;
            rb.MovePosition(rb.position + Vector2.left * step);
//            Debug.Log("moving left");
        }
        if(Input.GetKeyDown("d")){
            playerSprite.sprite = sideSprite;
            playerSprite.flipX = false;
            rb.MovePosition(rb.position+Vector2.right * step);
//            Debug.Log("moving right");
        }

    }
}
