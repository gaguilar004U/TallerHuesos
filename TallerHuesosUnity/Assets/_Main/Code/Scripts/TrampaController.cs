using UnityEngine;

/*
ESTADO: COMPLETADO✅
*/
public class TrampaController : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    void OnTriggerEnter2D(Collider2D Pincho)
    {
        if (Pincho.CompareTag("Player"))
        {
            gameManager.Vidas(-1);
        }
    }
}