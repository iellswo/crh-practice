using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;



public class Door : MonoBehaviour
{
    public Tilemap tileMap;

    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = tileMap.GetComponent<CenterOnTile>().Center(transform.position);

        if (Data.openDoors.Exists(door => door == transform.position))
        {
            Destroy(gameObject);
        } else if (!Data.doors.Exists(door => door.transform.position == transform.position))
        {
            Data.doors.Add(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        if (Data.keyCount > 0)
        {
            source.Play();
            Data.keyCount--;
            Data.openDoors.Add(transform.position);
            Data.doors.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}
