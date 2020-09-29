using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    public static float speedModifier = 1.0f;
    public static float SpeedModifier
    {
        get { return speedModifier;}
    }

    public enum GameSpeed {Slow = 1, Fast = 3}
    public static GameSpeed currentSpeedState = GameSpeed.Slow;
    public static GameSpeed CurrentSpeedState
    {
        get { return currentSpeedState;}
        set { currentSpeedState = value; speedModifier = (float)currentSpeedState;}
    }
    public SaveGameManager saveGameManager;
    // Start is called before the first frame update
    void Start()
    {        
        bool test = saveGameManager.LoadSpeed() == (int)GameSpeed.Slow;

        CurrentSpeedState = test ? CurrentSpeedState = GameSpeed.Slow :  CurrentSpeedState = GameSpeed.Fast;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
