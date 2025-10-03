using UnityEngine;

/*
ESTADO: COMPLETADO✅
*/
public class PuertaController : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private GameObject pantallaGanaste;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameManager.Llave)
            {
               gameManager.uiManager.EstadoDelJugador("Ganaste");
            }
        }
    }
}