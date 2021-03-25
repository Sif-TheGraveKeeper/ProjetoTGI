using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public int damage;
    public float destroyTime;
    
    void Start()
    {
        destroyTime = 1.0f;
        damage = 1;
        Destroy(gameObject, destroyTime);
    }

   
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Inimigo")) {

            Enemy inimigo = other.GetComponent<Enemy>();
            if (inimigo != null) {
                inimigo.DamageEnemy(damage); 
            }
        }

        Destroy(gameObject);


    }
        
       
    }




