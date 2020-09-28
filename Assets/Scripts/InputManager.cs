using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            bool test = SpeedManager.CurrentSpeedState == SpeedManager.GameSpeed.Slow;

            SpeedManager.CurrentSpeedState = test ? SpeedManager.CurrentSpeedState = SpeedManager.GameSpeed.Fast :  SpeedManager.CurrentSpeedState = SpeedManager.GameSpeed.Slow;
        }
    }
}
