using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/*
ESTADO: COMPLETADO✅
*/
public class GameManager : MonoBehaviour
{
    public UIManager uiManager;
    public string estado = "Play";

    [SerializeField] public int _puntos = 0;
    [SerializeField] public int _vidas = 5;
    [SerializeField] public bool _llave = false;
    public GameObject pausePanel; // Arrastra tu panel de pausa desde el Canvas
    private bool isPaused = false;
    //Textos
    /*[SerializeField]
    private TextMeshProUGUI textoTemporizador;
    [SerializeField]
    private TextMeshProUGUI textoCantPuntos;
    [SerializeField]
    private TextMeshProUGUI textoVidas;
    [SerializeField]
    private TextMeshProUGUI textoBoolLlave;
    //Tiempo
    [SerializeField]
    public float tiempoInicio = 60f;*/

    void Start()
    {
        uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        EstadoDelJugador(estado);
        if (pausePanel != null)
            pausePanel.SetActive(false);
    }

    void Update()
    {
        
        // Tecla ESC para pausar o reanudar
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ReanudarJuego();
                estado = "Play";
            }
            else
            {
                PausarJuego();
                estado = "Pause";
            }
        }
    }

    // ------------------ SISTEMA DE PUNTOS Y VIDAS ------------------
    public void SumarPuntos(int cantidad)
    {
        _puntos += cantidad;
        Debug.Log("Puntos actualizados: " + _puntos); // Debug para verificar cambios
    }

    public void Vidas(int cantidad)
    {
        _vidas += cantidad;
        Debug.Log("Vidas actualizadas: " + _vidas); // Debug para verificar cambios
        
        if (_vidas <= 0)
        {
            EstadoDelJugador("Perdiste");
        }
    }

    public void TieneLaLlave(bool estado)
    {
        _llave = estado;
        Debug.Log("Llave actualizada: " + _llave); // Debug para verificar cambios
    }

    // ------------------ CONTROL DE ESTADO DEL JUGADOR/JUEGO ------------------
    public void EstadoDelJugador(string estado)
    {
        Debug.Log("Estado actual: " + estado);
        switch (estado)
        {
            case "Play":
                Time.timeScale = 1;
                break;
            case "Pause":
                Time.timeScale = 0;
                break;
            case "Ganaste":
                SceneManager.LoadScene(2);
                break;
            case "Perdiste":
                SceneManager.LoadScene(1);
                break;
            case "Salir":
                Application.Quit();
                break;
        }
    }

    // ------------------ CONTROL DE ESCENAS ------------------
    public void ReiniciarEscena()
    {
        SceneManager.LoadScene(0);
    }

    // ------------------ FUNCIONES DE PAUSA ------------------
    public void PausarJuego()
    {
        EstadoDelJugador("Pause");
        if (pausePanel != null)
            pausePanel.SetActive(true);

        isPaused = true;
    }

    public void ReanudarJuego()
    {
        EstadoDelJugador("Play");
        if (pausePanel != null)
            pausePanel.SetActive(false);

        isPaused = false;
    }
    
    // ------------------ TEXTOS ------------------

}