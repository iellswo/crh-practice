using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SavePoint : MonoBehaviour
{
    public GameObject player;
    public int staminaRefresh;
    public Tilemap tileMap;
    private Vector3 thisSpot;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = tileMap.GetComponent<CenterOnTile>().Center(transform.position);
        if (!Data.saves.Exists(save => save.transform.position == transform.position))
        {
            Data.saves.Add(gameObject);
        }
    }

    // Update is called once per frame
    public void Save()
    {
        Debug.Log("SAVE");
        player.GetComponent<PlayerMovement>().stamina = staminaRefresh;
        Data.staminaMax = staminaRefresh;
        Data.savedLocation = transform.position;
    }
}
