using UnityEngine;
using TMPro;

/*
ESTADO: COMPLETADO✅
*/

public class MusloTiempo : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    public float tiempoInicio = 60f;

    [SerializeField]
    private TextMeshProUGUI textoTemporizador;
    [SerializeField]
    private TextMeshProUGUI textoCantPuntos;
    [SerializeField]
    private TextMeshProUGUI textoVidas;
    [SerializeField]
    private TextMeshProUGUI textoBoolLlave;
    void Update() 
    {
        tiempoInicio -= Time.deltaTime;
        textoTemporizador.text = "Tiempo Restante: " + tiempoInicio.ToString("f0");
        textoCantPuntos.text = "Puntos: " + gameManager._puntos.ToString();
        textoVidas.text = "Vidas: " + gameManager._vidas.ToString();
        string textoEstadoLlave = gameManager._llave ? "Si" : "No";
        textoBoolLlave.text = "Llave: " + textoEstadoLlave;


        if (tiempoInicio <= 0)
        {
            gameManager.ReiniciarEscena();
        }
    }
}
