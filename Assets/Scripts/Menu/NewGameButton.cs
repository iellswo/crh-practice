using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        Data.savedLocation = new Vector3(0, 0, 0);
        Data.staminaMax = 10;
        Data.keyCount = 0;
        Data.wins = new List<GameObject>();
        Data.levers = new List<GameObject>();
        Data.openDoors = new List<Vector3>();
        Data.keys = new List<GameObject>();
        Data.doors = new List<GameObject>();
        Data.cobwebs = new List<GameObject>();
        Data.saves = new List<GameObject>();
        SceneManager.LoadScene("Scenes/Game");
    }
}
