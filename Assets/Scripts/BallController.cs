using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D meuRb;

    void Start()
    {
        meuRb = GetComponent<Rigidbody2D>();

        // LÓGICA DO CARA OU COROA:
        // Random.Range(0, 2) vai dar 0 ou 1.
        // Se der 0, x vira -1 (Esquerda). Se der 1, x vira 1 (Direita).
        Reiniciar();
    }

    public void Reiniciar(){
        float x = (Random.Range(0, 2) == 0) ? -1 : 1; 

        // Fazemos o mesmo para o Y
        float y = (Random.Range(0, 2) == 0) ? -1 : 1;

        meuRb.velocity = new Vector2(x, y) * speed;
    }


}