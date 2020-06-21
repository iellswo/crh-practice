using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Cobweb : MonoBehaviour
{
    public Tilemap tileMap;

    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = tileMap.GetComponent<CenterOnTile>().Center(transform.position);
        if (!Data.cobwebs.Exists(web => web.GetComponent<Transform>().position == GetComponent<Transform>().position))
        {
            Data.cobwebs.Add(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Remove()
    {
        source.Play();
        Data.cobwebs.Remove(gameObject);
        Destroy(gameObject);
    }
}
