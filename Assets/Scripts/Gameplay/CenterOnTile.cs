using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CenterOnTile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public Vector3 Center(Vector3 location)
    {
        var centeredLocation = GetComponent<Tilemap>().CellToWorld(GetComponent<Tilemap>().WorldToCell(location));
        return centeredLocation + new Vector3(0.5f, 0.5f, 0f);
    }

    public bool SameTile(Vector3 locationA, Vector3 locationB)
    {
        bool result =  GetComponent<Tilemap>().WorldToCell(locationA) == GetComponent<Tilemap>().WorldToCell(locationB);
        Debug.Log(locationA + " = " + locationB + ": " + result);
        return result;
    }
}
