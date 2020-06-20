using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUI : MonoBehaviour
{
    public Sprite UIelement;
    // Start is called before the first frame update
    void Start()
    {
        UIelement = GetComponent<SpriteRenderer>().sprite;

    }

    // Update is called once per frame
    void Update()
    {
        if (Data.keyCount > 0)
        {
            GetComponent<SpriteRenderer>().sprite = UIelement;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = null;
        }
    }
}
