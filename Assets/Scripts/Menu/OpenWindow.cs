using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindow : MonoBehaviour
{

    public GameObject display;
//    public GameObject self;
//    public GameObject parent;

    public void openTextWindow()
    {
        GameObject newWindow = Instantiate(display, Vector3.zero, Quaternion.identity);
//        newWindow.transform.SetParent(parent.GetComponent<Canvas>().transform, false);
//        newWindow.GetComponent<DisplayWidow>().content = self;
    }
}
