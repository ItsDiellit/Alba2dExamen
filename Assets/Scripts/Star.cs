using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Star : MonoBehaviour

{
    [SerializeField]
    private string sceneToLoad; // Nombre de la escena que quieres cargar

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Comprueba si el objeto que colisiona tiene la etiqueta "Player"
        if (collision.CompareTag("Player"))
        {
            // Cargar la escena especificada
            SceneManager.LoadScene("Star");
        }
    }
}
