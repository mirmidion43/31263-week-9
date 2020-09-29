﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {    
    public Animator moveAnimator;

    private Vector3 movement;
    private float movementSqrMagnitude; 
    public AsyncLoader asyncLoader;
	
	void Update () {
        GetMovementInput();
        CharacterRotation();
        WalkingAnimation();
        asyncLoader.pos = gameObject.transform.position;
        asyncLoader.LoadLevelAsync();
	}


    void GetMovementInput() {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
        movement = Vector3.ClampMagnitude(movement, 1.0f);
        movementSqrMagnitude = movement.sqrMagnitude;
    }


    void CharacterRotation() {
        if (movement != Vector3.zero) {
            transform.rotation = Quaternion.LookRotation(movement, Vector3.up);
        }
    }


    void WalkingAnimation() {
        moveAnimator.SetFloat("MoveSpeed", movementSqrMagnitude * SpeedManager.SpeedModifier);
    }


}
