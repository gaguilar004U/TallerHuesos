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
                pantallaGanaste.SetActive(true);

                // Pausa el juego.
                Time.timeScale = 0f;
            }
        }
    }
}