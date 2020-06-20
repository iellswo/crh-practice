using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cobweb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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
        Data.cobwebs.Remove(gameObject);
        Destroy(gameObject);
    }
}
