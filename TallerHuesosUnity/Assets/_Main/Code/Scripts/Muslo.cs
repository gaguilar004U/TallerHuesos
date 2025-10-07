using UnityEngine;

//ESTADO: COMPLETADO✅


public class Muslo : MonoBehaviour
{
    [SerializeField]
    private MusloTiempo musloTiempo;
    [SerializeField]
    private GameManager gameManager;
    void OnTriggerEnter2D(Collider2D Tiempo)
    {
        if (Tiempo.CompareTag("Player"))
        {
            musloTiempo.tiempoInicio += 20f;
            Destroy(this.gameObject);
        }
    }
}
