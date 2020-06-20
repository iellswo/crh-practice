using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Key : MonoBehaviour
{
    public GameObject player;
    public Tilemap tileMap;
    private Vector3 thisSpot;
    private CenterOnTile center;
    // Start is called before the first frame update
    void Start()
    {
        
        center = tileMap.GetComponent<CenterOnTile>();
        thisSpot = center.Center(transform.position);
        if (!Data.keys.Exists(key => key.GetComponent<Transform>().position == GetComponent<Transform>().position))
        {
            Data.keys.Add(gameObject);
        }
    }

    // Update is called once per frame
    public void Pickup()
    {
        Debug.Log("KEY!");
        Data.keyCount++;
        Data.keys.Remove(gameObject);
        Destroy(gameObject);
    }
}
