using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameManager : MonoBehaviour
{
    const string saveKey = "all";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveSpeed(){
        PlayerPrefs.SetInt(saveKey, (int) SpeedManager.CurrentSpeedState);
        PlayerPrefs.Save();
    }

    public int LoadSpeed(){      
        return PlayerPrefs.GetInt(saveKey);
    }
}
