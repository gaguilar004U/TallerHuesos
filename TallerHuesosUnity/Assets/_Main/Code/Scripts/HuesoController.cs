using UnityEngine;

/*
ESTADO: COMPLETADO✅
*/
public class HuesoController : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManager.SumarPuntos(1);
            Destroy(this.gameObject);
        }
    }
}
