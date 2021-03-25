using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queda : MonoBehaviour
{
    private Jogador controlador;
    public Transform Player;
    private float UltimaPosicaoY, DistanciaDeQueda;
    public float DistanciaMaximaDeQueda = 4, DanoPorMetro = 5;

   
    void Start()
    {
        controlador = GetComponent<Jogador>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UltimaPosicaoY > Player.transform.position.y && GetComponent<Rigidbody2D>().velocity.y < 0) { 
        
             
        } 
    }
}
