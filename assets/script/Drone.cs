using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : Enemy
{
    
   
    void Start()
    {
        
    }

   
    protected override void Update()
    {
        base.Update();
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, Mathf.Abs(speed) * Time.deltaTime);
        }

    }
}
