using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsyncLoader : MonoBehaviour
{
    public Vector3 pos = new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevelAsync(){   
        Scene right = SceneManager.GetSceneByBuildIndex(5);
        Scene left = SceneManager.GetSceneByBuildIndex(4);
        Scene up = SceneManager.GetSceneByBuildIndex(2);
        Scene down = SceneManager.GetSceneByBuildIndex(3);
        //If pos.x> 2.5f, load RightScene (if it isn’t loaded) and unload LeftScene (if it is loaded)
        if(pos.x > 2.5f)
        {
            if(!right.isLoaded)
                SceneManager.LoadSceneAsync(5, LoadSceneMode.Additive);
            if(left.isLoaded)
                SceneManager.UnloadSceneAsync(4);
        }
        //If pos.x < -2.5f, load LeftScene (if it isn’t loaded) and unload RightScene (if it is loaded)
        if(pos.x < -2.5f)
        {
            if(!left.isLoaded)
                SceneManager.LoadSceneAsync(4, LoadSceneMode.Additive);
            if(right.isLoaded)
                SceneManager.UnloadSceneAsync(5);
        }
        //If pos.z > 2.5f, load TopScene (if it isn’t loaded) and unload BottomScene (if it is loaded)
        if(pos.z > 2.5f)
        {
            if(!up.isLoaded)
                SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);
            if(down.isLoaded)
                SceneManager.UnloadSceneAsync(3);
        }
        //If pos.z < -2.5f, load BottomScene (if it isn’t loaded) and unload TopScene (if it is loaded)
        if(pos.z < -2.5f)
        {
            if(!down.isLoaded)
                SceneManager.LoadSceneAsync(3, LoadSceneMode.Additive);
            if(up.isLoaded)
                SceneManager.UnloadSceneAsync(2);
        }
    }
}
