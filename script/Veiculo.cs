using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veiculo : MonoBehaviour
{
    private bool colidde = false;
    public float move ;
    void Start()
    {

    }


    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(move, GetComponent<Rigidbody2D>().velocity.y);
        if (colidde)
        {
            Flip();
        }

    }
    private void Flip()
    {
        move *= -1;
        GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
        colidde = false;
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Plataforma"))
        {
            colidde = true;
        }

    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Plataforma"))
        {
            colidde = false;

        }

    }
}
