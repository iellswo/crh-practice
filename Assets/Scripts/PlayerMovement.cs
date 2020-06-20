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
    private SpriteRenderer playerSprite;

    void Start()
    {
        stamina = Data.staminaMax;
        playerSprite = GetComponent<SpriteRenderer>();
        transform.position = tileMap.GetComponent<CenterOnTile>().Center(Data.savedLocation);
        
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

        TileBase newTile = tileMap.GetTile(tileMap.layoutGrid.WorldToCell(transform.position + movement));
        if (walkableTiles.Exists(tile => tile == newTile))
        {
            var aDoor = Data.doors.Find(door => door.transform.position == transform.position + movement);
            var aWeb = Data.cobwebs.Find(web => web.transform.position == transform.position + movement);
            var aLever = Data.levers.Find(lever => lever.transform.position == transform.position + movement);
            if (aDoor != null)
            {
                aDoor.GetComponent<Door>().Open();
            } else if (aWeb != null)
            {
                aWeb.GetComponent<Cobweb>().Remove();
                stamina--;
            } else if (aLever != null)
            {
                aLever.GetComponent<Lever>().Activate();
            }
            else
            {
                
                transform.position += movement;
                //not sure if we'll need to recenter after each step but here's the line if needed
                //playerTransform.position = tileMap.GetComponent<CenterOnTile>().Center(playerTransform.position);
                if (movement.magnitude > 0)
                {
                    stamina--;
                    Data.keys.Find(key => key.transform.position == transform.position)?.GetComponent<Key>().Pickup();
                    Data.saves.Find(save => save.transform.position == transform.position)?.GetComponent<SavePoint>().Save();
                }
                
            }
        }

        if (stamina <= 0)
        {
            Data.cobwebs = new List<GameObject>();
            Data.doors = new List<GameObject>();
            Data.keys = new List<GameObject>();
            Data.saves = new List<GameObject>();
            Data.keyCount = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
