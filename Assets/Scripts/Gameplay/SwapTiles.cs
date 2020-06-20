using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SwapTiles : MonoBehaviour
{
    public TileBase tile1;
    public Tilemap tileMap;

    private Vector3Int location;
    // Start is called before the first frame update
    void Start()
    {
        location = tileMap.WorldToCell(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate()
    {
        var tileTemp = tileMap.GetTile(location);
        tileMap.SetTile(location, tile1);
        tile1 = tileTemp;
    }
}
