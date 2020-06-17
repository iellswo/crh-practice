using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class BreakCrackedFloors : MonoBehaviour
{
	public GameObject player;
	public TileBase crackedFloor;
	public TileBase brokenFloor;
	public Tilemap tileMap;

    private TileBase oldTile;
	private Vector3Int oldLocation;
	private GridLayout grid;
	// Start is called before the first frame update
    void Start()
    {
		grid = GetComponent<GridLayout>();
		oldLocation = grid.WorldToCell(player.transform.position);
        oldTile = tileMap.GetTile(oldLocation);
    }

    // Update is called once per frame
    void Update()
    {
		var newLocation = grid.WorldToCell(player.transform.position);
		var newTile = tileMap.GetTile(newLocation);
		
	
		
        if(oldLocation == newLocation){
			Debug.Log("stayed at" + oldLocation);
			//no movement, exit early
			//in java iirc I'd just break; here but that's not making unity happy, have an else.
		} else {
			Debug.Log("move to" + newLocation);

			if(oldTile == crackedFloor){
				Debug.Log("CRACK!");
				tileMap.SetTile(oldLocation, brokenFloor);
			}
			//update records of where we are
			oldLocation = newLocation;
			oldTile = newTile;
		}
    }
}
