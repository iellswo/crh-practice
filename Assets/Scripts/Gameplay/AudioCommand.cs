using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCommand : MonoBehaviour
{
    static AudioCommand instance = null;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }

    public static void SilenceBGM()
    {
        Destroy(instance.transform.gameObject);
        instance = null;
    }
}
