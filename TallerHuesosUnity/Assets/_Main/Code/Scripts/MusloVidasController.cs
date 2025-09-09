using UnityEngine;

/*
ESTADO: COMPLETADO✅
*/
public class MusloVidasController : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    void OnTriggerEnter2D(Collider2D Vida)
    {
        if (Vida.CompareTag("Player"))
        {
            gameManager.Vidas(1);
            Destroy(this.gameObject);
        }
    }
}
