using UnityEngine;

/*
ESTADO: COMPLETADO✅
*/

public class ObstaculoController : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    void Update()
    {
        if (gameManager._puntos >= 10)
        {
            Destroy(this.gameObject);
        }
    }
}