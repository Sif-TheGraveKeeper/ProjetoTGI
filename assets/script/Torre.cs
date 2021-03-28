using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : Enemy
{
    
    void Start()
    {
        health = 4;
    }

    
    protected override void Update()
    {
        float distance = playerDistance();

        isMoving = (distance <= distanceAttack);

        if (isMoving) {
            if ((player.position.x > transform.position.x && sprite.flipX)||
                (player.position.x < transform.position.x && !sprite.flipX)) 
            {
                Flip();
            
            }
        }
        Debug.Log(distance);

    }
    private void FixedUpdate()
    {
        if (isMoving)
        {
            rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        }
    }
}
