using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class Data
{
    public static Vector3 savedLocation = new Vector3(0, 0, 0);
    public static int staminaMax = 10;
    public static int keyCount = 0;
    public static List<GameObject> wins = new List<GameObject>();
    public static List<GameObject> levers = new List<GameObject>();
    public static List<Vector3> openDoors = new List<Vector3>();
    public static List<GameObject> keys = new List<GameObject>();
    public static List<GameObject> doors = new List<GameObject>();
    public static List<GameObject> cobwebs = new List<GameObject>();
    public static List<GameObject> saves = new List<GameObject>();
}
