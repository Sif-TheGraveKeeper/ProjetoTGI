using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeiculoDes : MonoBehaviour
{
    private bool colidde = false;
    public float moveSp;
    void Start()
    {

    }


    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveSp, GetComponent<Rigidbody2D>().velocity.x);
       
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
