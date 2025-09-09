using UnityEngine;

/*
ESTADO: COMPLETADO✅
*/
public class LLaveController : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    void OnTriggerEnter2D(Collider2D Llave)
    {
        if (Llave.CompareTag("Player"))
        {
            gameManager.TieneLaLlave(true);
            Destroy(this.gameObject);
        }
    }
}