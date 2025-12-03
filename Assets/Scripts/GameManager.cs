using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Precisamos checar se o objeto que entrou é a Bola
        // A variável 'collision' traz informações sobre quem bateu
        
        if (collision.gameObject.name == "Bola") // Ou usar Tags...
        {
            Debug.Log("GOL! Reiniciando a bola...");
            
            // Aqui vamos mandar a bola reiniciar...
        }
    }
}

