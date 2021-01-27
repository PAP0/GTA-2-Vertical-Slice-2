using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private IMoveable _controllingMovement;

    public void GainControl(IMoveable movable)
    {
        _controllingMovement = movable;
    }

    public void Update()
    {
        if(_controllingMovement != null)
        {
            if(Input.GetKey(KeyCode.A))
            {  
               _controllingMovement.RotateLeft(); 
            }
            if(Input.GetKey(KeyCode.D))
            {
               _controllingMovement.RotateRight();
            }

            if(Input.GetKey(KeyCode.W))
            {
                _controllingMovement.MoveForward();
            }
            if(Input.GetKey(KeyCode.S))
            {
                _controllingMovement.MoveBackwards();
            }
        }
    }
}
