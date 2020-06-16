using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class BreakCrackedFloors : MonoBehaviour
{
	public GameObject player;
	public TileBase crackedFloor;
	public TileBase brokenFloor;
	
	private Tilemap tileMap;
    private TileBase oldTile;
	private Vector3 oldLocation;
	// Start is called before the first frame update
    void Start()
    {
		tileMap = GetComponent<Tilemap>();
		oldLocation = player.transform.position;
        oldTile = tileMap.GetTile(Vector3Int.FloorToInt(oldLocation));
    }

    // Update is called once per frame
    void Update()
    {
		var newLocation = player.transform.position;
		var newTile = tileMap.GetTile(Vector3Int.FloorToInt(newLocation));

        if(oldLocation == newLocation){
			Debug.Log("stayed at" + oldLocation);
			//no movement, exit early
			//in java iirc I'd just break; here but that's not making unity happy, have an else.
		} else {
			Debug.Log("move to" + newLocation);

			if(oldTile == crackedFloor){
				Debug.Log("CRACK!");
				tileMap.SetTile(Vector3Int.FloorToInt(oldLocation), brokenFloor);
			}
		
			//update records of where we are
			oldLocation = player.transform.position;
			oldTile = newTile;

		}
    }
}
