using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    private Vector3 target = new Vector3(-3,1,0);
    private float duration = 1.5f;
    public Tweener tweener;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!tweener.TweenExists(transform))
        {
            //flip target in x axis
            target.x = target.x * -1;
            //add a new tween with the sphere's trranform, current transform position, target and the duration variable divided by SpeedModifier from SpeedManager
            tweener.AddTween(transform, transform.position, target, duration/SpeedManager.SpeedModifier);
        }
    }
}
