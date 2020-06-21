using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class WinScript : MonoBehaviour
{
    public Tilemap tileMap;
    private Vector3 thisSpot;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = tileMap.GetComponent<CenterOnTile>().Center(transform.position);
        if (!Data.wins.Exists(save => save.transform.position == transform.position))
        {
            Data.wins.Add(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Win()
    {
        SceneManager.LoadScene("Scenes/Win");
    }
}
