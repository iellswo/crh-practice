using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!Data.doors.Exists(door => door.GetComponent<Transform>().position == GetComponent<Transform>().position))
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
            Data.doors.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}
