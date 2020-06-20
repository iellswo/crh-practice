using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
            Data.keyCount--;
            Data.openDoors.Add(transform.position);
            Data.doors.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}
