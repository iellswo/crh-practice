using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DarknessLayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Tilemap tileMap;
    public TileBase darkness;
    void Start()
    {
        
        tileMap.BoxFill(new Vector3Int(0,0,0), darkness, -40,-40,10,10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
