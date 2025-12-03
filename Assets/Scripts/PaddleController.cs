using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour

{
    public float speed = 10.0f;
    
    // Criamos essa variável para digitar "Vertical" ou "Vertical2" na Unity
    public string nomeDoEixo = "Vertical"; 

    private Rigidbody2D meuRb;

    void Start()
    {
        meuRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Agora usamos a variável aqui dentro, e não o texto fixo!
        float meuY = Input.GetAxisRaw(nomeDoEixo) * speed;
        meuRb.velocity = new Vector2(0, meuY);
    }
}