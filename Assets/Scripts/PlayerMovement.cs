using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public int stamina;
    public Sprite upSprite;
    public Sprite downSprite;
    public Sprite sideSprite;
    public Tilemap tileMap;
    public List<TileBase> walkableTiles;
    public Vector3 startingLocation;
    private Transform playerTransform;
    private SpriteRenderer playerSprite;

    void Start()
    {
        
        playerSprite = GetComponent<SpriteRenderer>();
        playerTransform = GetComponent<Transform>();
        playerTransform.position = CenterOnTile(Data.savedLocation);

        // currentTile = room
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0,0,0);
        if(Input.GetKeyDown("w"))
        {
            playerSprite.sprite = upSprite;
            playerSprite.flipX = false;
            movement = Vector3.up;
//            Debug.Log("moving up");
        }
        if(Input.GetKeyDown("s")){
            playerSprite.sprite = downSprite;
            playerSprite.flipX = false;
            movement = Vector3.down;
//            Debug.Log("moving down");
        }
        if(Input.GetKeyDown("a")){
            playerSprite.sprite = sideSprite;
            playerSprite.flipX = true;
            movement = Vector3.left;
//            Debug.Log("moving left");
        }
        if(Input.GetKeyDown("d")){
            playerSprite.sprite = sideSprite;
            playerSprite.flipX = false;
            movement = Vector3.right;
//            Debug.Log("moving right");
        }

        TileBase newTile = tileMap.GetTile(tileMap.layoutGrid.WorldToCell(playerTransform.position + movement));
        if (walkableTiles.Exists(tile => tile == newTile))
        {
            playerTransform.position += movement;
            if(movement.magnitude > 0){stamina--;}
            
        }

        if (stamina <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    
    }

    public Vector3 CenterOnTile(Vector3 location)
    {
        var centeredLocation = tileMap.layoutGrid.CellToWorld(tileMap.layoutGrid.WorldToCell(location));
        return centeredLocation + new Vector3(0.5f, 0.5f, 0f);
    }
}
