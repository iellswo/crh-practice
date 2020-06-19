using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePoint : MonoBehaviour
{
    public GameObject player;
    public int staminaRefresh;
    private Vector3 thisSpot;
    // Start is called before the first frame update
    void Start()
    {
        thisSpot = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        var playerMoveScript = player.GetComponent<PlayerMovement>();
        var playerLocation = player.GetComponent<Transform>().position;
        if (playerMoveScript.CenterOnTile(playerLocation) == playerMoveScript.CenterOnTile(thisSpot))
        {
            playerMoveScript.stamina = staminaRefresh;
            Data.savedLocation = thisSpot;
        }
    }
}
