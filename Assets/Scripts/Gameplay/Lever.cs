using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public List<SwapTiles> gizmos;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!Data.levers.Exists(lever => lever.transform.position == transform.position))
        {
            Data.levers.Add(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate()
    {
        gizmos.ForEach(gizmo => gizmo.Activate());
        GetComponent<SpriteRenderer>().flipX ^= true;
    }
}
