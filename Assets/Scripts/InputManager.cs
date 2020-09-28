using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

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

        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(GameManger.currentGameState == GameManger.GameState.Start)
                SceneManager.LoadScene(1);
                Destroy(GetComponent<Tweener>());
        }
    }
}
