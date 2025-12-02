using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public bool IsPlayer1;
    public float speed;
    public Rigidbody2D rb;

    private float movement;
    
    void Update()
    {
         if (IsPlayer1){
        movement = Input.GetAxisRaw ("Vertical");

    } else {
        movement = Input.GetAxisRaw ("Vertical2");
    }

    rb.velocity = new Vector2(rb.velocity.x, movement * speed);
        
    }
}
