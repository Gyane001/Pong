using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

   private void OnTriggerEnter2D(Collider2D collision)

   Start(){
    collision.transform.position = new Vector2(0, 0);
   }
}

