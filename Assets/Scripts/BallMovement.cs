using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    bool isMovingFwd, isMovingBwd, isMovingLeft, isMovingRight; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (isMovingFwd)
       {
          MoveForward();
       }

        if (isMovingBwd)
       {
          MoveBackward();
       }

        if (isMovingLeft)
       {
          MoveLeft();
       }

        if (isMovingRight)
       {
          MoveRight();
       }
    }

    public void MoveForward()
    {
        this.gameObject.transform.position = this.gameObject.transform.position + new Vector3(0, 0, 0.04f);
    }

    public void MoveBackward()
    {
        this.gameObject.transform.position = this.gameObject.transform.position + new Vector3(0, 0, -0.04f);
    }

    public void MoveLeft()
    {
        this.gameObject.transform.position = this.gameObject.transform.position + new Vector3(-0.04f, 0, 0);
    }

    public void MoveRight()
    {
        this.gameObject.transform.position = this.gameObject.transform.position + new Vector3(0.04f, 0, 0);
    }

    public void TriggerForward(bool isMoving)
    {
        isMovingFwd = isMoving;
    }

    public void TriggerBackward(bool isMoving)
    {
        isMovingBwd = isMoving;
    }

    public void TriggerLeft(bool isMoving)
    {
        isMovingLeft = isMoving;
    }

    public void TriggerRight(bool isMoving)
    {
        isMovingRight = isMoving;
    }
}
